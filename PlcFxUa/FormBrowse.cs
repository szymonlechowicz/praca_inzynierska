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

namespace PlcFxUa
{
    public partial class FormBrowse : Form
    {
        private FormStart parent;
        private Session session;
        private Subscription subscription;
        private List<NodeInfo> nodeInfo;
        private BrowsingClass browsing;
        public FormBrowse()
        {
            InitializeComponent();
        }

        public FormBrowse(FormStart formStart, Session mainSession)
        {
            InitializeComponent();

            treeServer.Nodes.Clear();
            this.parent = formStart;
            this.session = mainSession;
            
            if (this.session != null)
            {
                this.browsing = new BrowsingClass(this.session);
            }
            if (this.subscription == null)
            {
                subscriptionLabel.Text = "No subscription.\nDouble click node to subscribe";
            }
            if (session == null || !session.Connected)
            {
                MessageBox.Show("Not connected to server");
                treeServer.Visible = false;
                return;
            }

            try
            {
                treeServer.BeginUpdate();
                browsing.Populate(ObjectIds.ObjectsFolder, treeServer.Nodes);
                treeServer.EndUpdate();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        
        private void treeServer_AfterSelect(object sender, TreeViewEventArgs e)
        {

            ReferenceDescription rd = e.Node.Tag as ReferenceDescription;

            if (rd == null || rd.NodeId.IsAbsolute)
            {
                return;
            }
            else
            {
                this.nodeInfo = getNodeInfo(rd);
                tableBrowser.DataSource = this.nodeInfo;
            }
            browsing.Populate((NodeId)rd.NodeId, e.Node.Nodes);


            tableBrowser.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tableBrowser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            tableBrowser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            tableBrowser.RowHeadersVisible = false;
            tableBrowser.Visible = true;
            WrapContent(tableBrowser);
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

        private List<NodeInfo> getNodeInfo(ReferenceDescription rd)
        {
            Node node = new Node(rd);

            var list = new List<NodeInfo>();
            list.Add(new NodeInfo()
            {
                Attribute = "Display name",
                Value = rd.DisplayName.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Node ID",
                Value = rd.NodeId.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Namespace index",
                Value = rd.NodeId.NamespaceIndex.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Node Class",
                Value = rd.NodeClass.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Type Definition",
                Value = rd.TypeDefinition.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Browse Name",
                Value = rd.BrowseName.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Identifier Type",
                Value = rd.NodeId.IdType.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "User Write Mask",
                Value = node.UserWriteMask.ToString()
            });

            list.Add(new NodeInfo()
            {
                Attribute = "Write Mask",
                Value = node.WriteMask.ToString()
            });

            return list;
        }

        private void treeServer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (session == null || !session.Connected)
                {
                    subscriptionLabel.Text = "No session";
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


                ReferenceDescription rd = e.Node.Tag as ReferenceDescription;

                if (rd == null || rd.NodeId.IsAbsolute)
                {
                    return;
                }
                else
                {
                    var item = new MonitoredItem(subscription.DefaultItem)
                    {
                        DisplayName = rd.DisplayName.ToString(),
                        StartNodeId = rd.NodeId.ToString(),
                    };
                    item.Notification += OnNotification;
                    subscription.AddItem(item);

                    nameLabel.Text = rd.DisplayName.ToString();
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
            subscriptionLabel.Text = "Value: " + ((MonitoredItemNotification)e.NotificationValue).Value.WrappedValue.ToString() + "\n"
                + "Status Code: " + ((MonitoredItemNotification)e.NotificationValue).Value.StatusCode.ToString() + "\n"
                + "Source Timestramp: " + ((MonitoredItemNotification)e.NotificationValue).Value.SourceTimestamp.ToString() + "\n"
                + "Server Timestramp: " + ((MonitoredItemNotification)e.NotificationValue).Value.ServerTimestamp.ToString();

        }
        private void UpdateParent()
        {
            parent.GetSession(session);
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
    }

}
