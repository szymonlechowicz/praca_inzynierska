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
    public partial class FormVariables : Form
    {
        // TO TRY: Reading more items and changing them
        // TO DO: reading structure: new form?
        private FormStart parent;
        private BrowsingClass browsing;
        private Session session;
        private Subscription subscription;
        private string dataType;
        private MBase context;
        private NodeId changeableNode;
        private bool firstSelection;
        public FormVariables(FormStart formStart, Session mainSession, MBase mainContext)
        {
            InitializeComponent();

            this.parent = formStart;
            this.session = mainSession;
            if (this.session != null)
            {
                this.browsing = new BrowsingClass(this.session);
                treeServer.BeginUpdate();
                browsing.Populate(ObjectIds.ObjectsFolder, treeServer.Nodes);
                treeServer.EndUpdate();
            }
            this.context = mainContext;
            this.firstSelection = true;
            
        }

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
                browsing.Populate((NodeId)rd.NodeId, e.Node.Nodes);
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

                    var item = new MonitoredItem()
                    {
                        DisplayName = rd.DisplayName.ToString(),
                        StartNodeId = rd.NodeId.ToString(),
                    };
                    item.Notification += OnNotification;
                    
                    //item.MonitoringMode = MonitoringMode.Reporting;
                    subscription.AddItem(item);
                    

                    //nameLabel.Text = rd.DisplayName.ToString();
                }

                subscription.ApplyChanges();
                UpdateParent();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
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

            
            //nameLabel.Text = item.DisplayName;
            //MonitorLabel.Text = "Value: " + data.Value.Value +
            //    "\nDataType: " + type + "\nTime: " + data.Value.SourceTimestamp.ToString() +
            //    "\n\n If you want, add this to list of monitored items";
            
            string nodeId = item.StartNodeId.ToString();

            var measurement = new Measurement()
            {
                time = data.Value.SourceTimestamp,
                value = data.Value.Value.ToString()
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
            
        }

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

        private void ItemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ItemsView.Rows[e.RowIndex];

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
                        
                        context.Items.Remove(item);
                        context.SaveChanges();

                        CreateView();
                        break;
                    }
                //writing
                case 3:
                    {
                        row.ReadOnly = false;
                        btnModify.Enabled = true;
                        WriteTextBox.Enabled = true;
                        row.ReadOnly = true;

                        var monitoredItem = new MonitoredItem
                        {
                            StartNodeId = row.Cells[5].Value.ToString(),
                            DisplayName = row.Cells[1].Value.ToString()
                        };
                        
                        string nodeToWrite = monitoredItem.StartNodeId.ToString();
                        var item = context.Items.Single(i => i.nodeId == nodeToWrite);


                        this.changeableNode = nodeToWrite;
                        this.dataType = item.dataType;

                        break;
                    }
            }

        }
        
        private void btnModify_Click(object sender, EventArgs e)
        {
            WriteNode();
            CreateView();
        }

        private void WriteTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteNode();
                CreateView();
            }
        }

        private void WriteNode()
        {
            try
            {
                WriteValue valueToWrite = new WriteValue();
                valueToWrite.NodeId = changeableNode;
                valueToWrite.AttributeId = Attributes.Value;
                valueToWrite.Value.Value = SetTypeAndValue();
                valueToWrite.Value.StatusCode = StatusCodes.Good;
                valueToWrite.Value.ServerTimestamp = DateTime.MinValue;
                valueToWrite.Value.SourceTimestamp = DateTime.MinValue;

                WriteValueCollection valuesToWrite = new WriteValueCollection();
                valuesToWrite.Add(valueToWrite);

                StatusCodeCollection results = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                this.session.Write(
                    null,
                    valuesToWrite,
                    out results,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(results, valuesToWrite);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, valuesToWrite);

                if (StatusCode.IsBad(results[0]))
                {
                    throw new ServiceResultException(results[0]);
                }

                DialogResult = DialogResult.OK;
                Thread.Sleep(1000);

                parent.operationLabel.Text = "Writing completed.";
                parent.operationLabel.Visible = true;
                btnModify.Enabled = false;
                WriteTextBox.Enabled = false;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private object SetTypeAndValue()
        {
            //object tempValue = (value != null) ? value.Value : null;
            object tempValue;

            switch (dataType)
            {
                case "Boolean":
                    {
                        tempValue = Convert.ToBoolean(WriteTextBox.Text);
                        break;
                    }

                case "SByte":
                    {
                        tempValue = Convert.ToSByte(WriteTextBox.Text);
                        break;
                    }

                case "Byte":
                    {
                        tempValue = Convert.ToByte(WriteTextBox.Text);
                        break;
                    }

                case "Int16":
                    {
                        tempValue = Convert.ToInt16(WriteTextBox.Text);
                        break;
                    }

                case "UInt16":
                    {
                        tempValue = Convert.ToUInt16(WriteTextBox.Text);
                        break;
                    }

                case "Int32":
                    {
                        tempValue = Convert.ToInt32(WriteTextBox.Text);
                        break;
                    }

                case "UInt32":
                    {
                        tempValue = Convert.ToUInt32(WriteTextBox.Text);
                        break;
                    }

                case "Int64":
                    {
                        tempValue = Convert.ToInt64(WriteTextBox.Text);
                        break;
                    }

                case "UInt64":
                    {
                        tempValue = Convert.ToUInt64(WriteTextBox.Text);
                        break;
                    }

                case "Float":
                    {
                        tempValue = Convert.ToSingle(WriteTextBox.Text);
                        break;
                    }

                case "Double":
                    {
                        tempValue = Convert.ToDouble(WriteTextBox.Text);
                        break;
                    }

                default:
                    {
                        tempValue = WriteTextBox.Text;
                        break;
                    }
            }

            return tempValue;
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
        }
    }
}
