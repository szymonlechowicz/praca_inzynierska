using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Opc.Ua;
using Opc.Ua.Client;
using System.Threading;
using System.Data.Entity;
using System.Reflection;
using System.IO;

namespace PlcFxUa
{
    public partial class FormData : Form
    {
        private FormStart parent;
        private Session session;
        private Subscription subscription;
        private BrowsingClass browsing;
        private MBase context;
        private bool print;
        private bool stopMonitoring = false;
        private bool permToSave;
        public FormData(FormStart formStart, Session mainSession, MBase mainContext)
        {
            InitializeComponent();
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
                print = true;
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

                    permToSave = true;
                    stopMonitoring = false;
                    lineChart.Visible = true;
                    btnResume.Enabled = false;

                    nodeLabel.Text = rd.DisplayName.ToString();
                    var item = new MonitoredItem(subscription.DefaultItem)
                    {
                        DisplayName = rd.DisplayName.ToString(),
                        StartNodeId = rd.NodeId.ToString(),
                    };
                    //var newItem = new Monitored { item = item };

                    item.Notification += OnNotification;
                    subscription.AddItem(item);

                    
                    //context.MonitoredItems.Add(newItem);

                    //currentMonitoredItems.Add(item);

                }

                subscription.ApplyChanges();
                UpdateParent();
                treeServer.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
        {

            if (!stopMonitoring)
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

                var measurements = (from m in context.Measurements select m).ToList();


                DrawChart(measurements);
            }
        }

        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
        }
        private void DrawChart(List<Measurement> measurements)
        {
            // TO TRY:
            // 1) dictionary <string, double>
            // 2) OXYPLOT
            if (this.print)
            {
                lineChart.Series.Clear();
                lineChart.Series.Add("Measure");
                lineChart.Series["Measure"].ChartType = SeriesChartType.Line;
                double x;
                foreach (var measurement in measurements)
                {
                    x = (measurement.time.Ticks - measurement.time.Ticks) / 10000000;
                    lineChart.Series["Measure"].Points.AddXY(x, Convert.ToDouble(measurement.value));
                }
            }
            else return;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.print = false;
            btnResume.Enabled = true;
            btnPause.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            this.print = true;
            btnPause.Enabled = true;
            btnResume.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.print = false;
            lineChart.Series.Clear();

            stopMonitoring = true;
            context.Database.ExecuteSqlCommand("Delete from Measurements");
            this.print = true;
            treeServer.SelectedNode = null;
            nodeLabel.Text = "Select node";
            treeServer.Enabled = true;
            this.permToSave = false;
        }

        private void FormData_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.print = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.permToSave)
            {
                context.Measurements.Load();
                var measurements = (from m in context.Measurements select m).ToList();
                ExportCSV(measurements, "data");
            }
            else MessageBox.Show("No permission to save");
        }
        
        private static void ExportCSV<T>(List<T> list, string fileName)
        {
            try
            {
                var sb = new StringBuilder();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName + ".csv");
                string header = "";
                PropertyInfo[] props = typeof(T).GetProperties();
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream file = File.Create(path);
                file.Close();
                foreach (var prop in props)
                    header += prop.Name + "; ";
                header = header.Substring(0, header.Length - 2);
                sb.AppendLine(header);
                var writer = new StreamWriter(path, true);
                writer.Write(sb.ToString());
                writer.Close();
                foreach (var obj in list)
                {
                    sb = new StringBuilder();
                    string line = "";
                    foreach (var prop in props)
                        line += prop.GetValue(obj, null) + "; ";
                    line = line.Substring(0, line.Length - 2);
                    sb.AppendLine(line);
                    writer = new StreamWriter(path, true);
                    writer.Write(sb.ToString());
                    writer.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
    }
}
