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

namespace PlcFxUa
{
    public partial class FormStructure : Form
    {
        private FormStart parent;
        private Session session;
        private MBase context;
        private BrowsingClass browsing;
        private Subscription subscription;
        public FormStructure()
        {
            InitializeComponent();
        }
        public FormStructure(FormStart formStart, Session mainSession, MBase mainContext)
        {
            this.parent = formStart;
            this.session = mainSession;
            this.context = mainContext;
            if (this.session != null)
            {
                this.browsing = new BrowsingClass(this.session);
                treeServer.BeginUpdate();
                browsing.Populate(ObjectIds.ObjectsFolder, treeServer.Nodes);
                treeServer.EndUpdate();
            }
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

                ReferenceDescription rd = e.Node.Tag as ReferenceDescription;

                if (rd == null || rd.NodeId.IsAbsolute)
                {
                    return;
                }
                else
                {
                    if (context == null)
                        context = new MBase();

                    structureLV.Visible = true;

                    var item = new MonitoredItem()
                    {
                        DisplayName = rd.DisplayName.ToString(),
                        StartNodeId = rd.NodeId.ToString(),
                    };
                    item.Notification += OnNotification;

                    subscription.AddItem(item);

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

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

            
        }
        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
        }

    }
}
