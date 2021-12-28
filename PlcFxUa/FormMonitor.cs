using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua.Client;
using Opc.Ua;
using Opc.Ua.Configuration;
using System.Threading;

namespace PlcFxUa
{
    public partial class FormMonitor : Form
    {
        #region Private Fields
        private FormStart parent;
        private BrowsingClass browsing;
        private Session session;
        private Subscription subscription;
        private MBase context;
        private bool firstSelection;
        private Writer writer;
        #endregion

        #region Constructors
        public FormMonitor(FormStart formStart, Session mainSession, MBase mainContext)
        {
            InitializeComponent();

            this.parent = formStart;
            this.session = mainSession;
            if (this.session != null)
            {
                this.browsing = new BrowsingClass(this.session);
                this.writer = new Writer(this.session, this.parent);
                treeServer.BeginUpdate();
                browsing.Populate(ObjectIds.ObjectsFolder, treeServer.Nodes);
                treeServer.EndUpdate();
            }
            this.context = mainContext;
            this.firstSelection = true;
            if (this.context != null)
                CreateView();
            label1.Text = "Select node to monitor by single click on treeview. You can change the value of node\n" +
                "by single click on value and by change value in the textbox next to button 'Modify'.\n" +
                "NOTICE! If you delete monitored item from the list, you delete it as well from database";
        }
        #endregion

        #region Private Members
        private void CreateView()
        {
            var query = context.Items.Select(i => new
            {
                displayName = i.displayName,
                dataType = i.dataType,
                value = i.measurements.OrderByDescending(m => m.time).Select(m => m.value).FirstOrDefault(),
                time = i.measurements.OrderByDescending(m => m.time).Select(m => m.time).FirstOrDefault(),
                nodeId = i.nodeId,
            });

            ItemsView.DataSource = query.ToList();

            WrapContent(ItemsView);
        }
        private void AcceptWriting()
        {
            this.writer.WriteNode(this, ItemsView.CurrentRow.Cells[5].Value.ToString());
            CreateView();
            btnModify.Enabled = false;
            WriteTextBox.Enabled = false;
        }
        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
        }
        private void WrapContent(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count;
            var totalWidth = dgv.Columns.GetColumnsWidth(states);
            dgv.ClientSize = new Size(totalWidth, totalHeight);
            dgv.AutoResizeColumns(
            DataGridViewAutoSizeColumnsMode.AllCells);
        }
        #endregion

        #region Event Handlers
        private void treeServer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                // check if node has already been expanded once.
                if (e.Node.Nodes.Count != 1 || e.Node.Nodes[0].Text != String.Empty)
                {
                    return;
                }

                // get the source for the node.
                ReferenceDescription rd = e.Node.Tag as ReferenceDescription;

                if (rd == null || rd.NodeId.IsAbsolute)
                {
                    e.Cancel = true;
                    return;
                }

                // populate children.
                browsing.Populate((NodeId)rd.NodeId, e.Node.Nodes, (uint)(NodeClass.Object | NodeClass.ObjectType |
                NodeClass.Variable | NodeClass.ReferenceType));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void treeServer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (firstSelection)
                {
                    if (session == null || !session.Connected)
                    {
                        return;
                    }

                    if (subscription != null)
                    {
                        session.RemoveSubscription(subscription);
                        subscription = null;
                    }

                    subscription = new Subscription();
                    subscription.PublishingEnabled = true;
                    subscription.PublishingInterval = 1000;
                    subscription.Priority = 1;
                    subscription.KeepAliveCount = 10;
                    subscription.LifetimeCount = 20;
                    subscription.MaxNotificationsPerPublish = 1000;

                    session.AddSubscription(subscription);
                    subscription.Create();
                    
                    this.firstSelection = false;
                }
                ReferenceDescription rd = e.Node.Tag as ReferenceDescription;

                if (rd == null || rd.NodeId.IsAbsolute)
                {
                    return;
                }
                else
                {
                    if (context == null)
                        context = new MBase();

                    ItemsView.Visible = true;
                    this.parent.stopMonitoring = false;

                    var item = new MonitoredItem()
                    {
                        DisplayName = rd.DisplayName.ToString(),
                        StartNodeId = rd.NodeId.ToString(),
                    };
                    item.Notification += OnNotification;
                    
                    subscription.AddItem(item);
                    
                }

                subscription.ApplyChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void ItemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ItemsView.Rows[e.RowIndex];
            
            btnModify.Enabled = false;
            WriteTextBox.Enabled = false;

            switch (e.ColumnIndex)
            {
                // deleting
                case 0:
                    {
                        var monitoredItem = new MonitoredItem
                        {
                            StartNodeId = row.Cells[5].Value.ToString(),
                            DisplayName = row.Cells[1].Value.ToString()
                        };
                        monitoredItem.MonitoringMode = MonitoringMode.Disabled;
                        subscription.RemoveItem(monitoredItem);
                        

                        string nodeToRemove = monitoredItem.StartNodeId.ToString();
                        var item = context.Items.Single(i => i.nodeId == nodeToRemove);

                        var measurements = context.Measurements.Where(m => m.monitoredId == item.ID);
                        context.Measurements.RemoveRange(measurements);

                        context.Items.Remove(item);
                        context.SaveChanges();

                        CreateView();
                        break;
                    }
                //writing
                case 3:
                    {
                        try
                        {
                            parent.operationLabel.Text = null;
                            parent.operationLabel.Visible = false;

                            var monitoredItem = new MonitoredItem
                            {
                                StartNodeId = row.Cells[5].Value.ToString(),
                                DisplayName = row.Cells[1].Value.ToString()
                            };
                            
                            
                            string nodeToWrite = monitoredItem.StartNodeId.ToString();
                            var item = context.Items.Single(i => i.nodeId == nodeToWrite);

                            if (item.dataType[item.dataType.Length-1] == ']')
                            {
                                MessageBox.Show("Error! It is array, you cannot change it!");
                            }
                            else
                            {
                                this.writer.SetWriter(item.dataType, WriteTextBox);

                                btnModify.Enabled = true;
                                WriteTextBox.Enabled = true;
                                WriteTextBox.Text = ItemsView.CurrentCell.Value.ToString();

                                Thread.Sleep(1000);
                                context.Items.Remove(item);
                                context.SaveChanges();
                            }
                            
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        break;
                    }
            }

        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            AcceptWriting();
        }
        private void WriteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AcceptWriting();
            }
        }
        private void FormMonitor_Click(object sender, EventArgs e)
        {
            ItemsView.DataSource = null;
            ItemsView.Rows.Clear();
        }

        private void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
        {
            if (!parent.stopMonitoring)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        BeginInvoke(new MonitoredItemNotificationEventHandler(OnNotification), item, e);
                        return;
                    }

                    MonitoredItemNotification data = e.NotificationValue as MonitoredItemNotification;

                    if (data == null) return;

                    string type = data.Value.WrappedValue.TypeInfo.BuiltInType.ToString();
                    if (data.Value.WrappedValue.TypeInfo.ValueRank >= 0)
                        type += "[]";

                    string nodeId = item.StartNodeId.ToString();

                    var measurement = new Measurement()
                    {
                        time = data.Value.SourceTimestamp,
                        value = data.Value.WrappedValue.ToString()
                    };
                    
                    if (!context.Items.Any(i => i.nodeId == nodeId))
                    {
                        var monitoredItem = new Item
                        {
                            nodeId = nodeId,
                            displayName = item.DisplayName,
                            dataType = type,
                            measurements = new List<Measurement>()
                        };

                        monitoredItem.measurements.Add(measurement);
                        context.Items.Add(monitoredItem);
                        context.SaveChanges();
                    }
                    else
                    {
                        Item monitoredItem = context.Items.FirstOrDefault(i => i.nodeId == nodeId);
                        monitoredItem.measurements.Add(measurement);
                        context.SaveChanges();
                    }

                    CreateView();
                    UpdateParent();
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }
        #endregion
    }
}
