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
using System.Data.Entity;
using System.Reflection;
using System.IO;


namespace PlcFxUa
{
    public partial class FormData : Form
    {
        #region Private Fields
        private FormStart parent;
        private Session session;
        private BrowsingClass browsing;
        private MBase context;
        private bool print;
        private bool permToSave;
        private string nodeId;
        private string displayName;
        private System.Windows.Forms.Timer timer;
        private Reader reader;
        #endregion

        #region Constructors
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

                this.reader = new Reader(this, this.session);
            }
            label1.Text = "Select node which you want to see how its value changes in time.\nYou can save measurements in CSV file and open it.";
        }
        #endregion

        #region Private Members
        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
        }
        private void DrawChart(List<Measurement> measurements, string seriesName)
        {
            // TO TRY:
            // 1) dictionary <string, double>
            // 2) OXYPLOT
            if (this.print)
            {
                lineChart.Series.Clear();
                lineChart.Series.Add(seriesName);
                lineChart.Series[seriesName].ChartType = SeriesChartType.Line;
                double x;
                foreach (var measurement in measurements)
                {
                    x = (measurement.time.Ticks - measurement.time.Ticks) / 10000000;
                    lineChart.Series[seriesName].Points.AddXY(x, Convert.ToDouble(measurement.value));
                }
            }
            else return;
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
        private void AddToDB(DataValue dataValue, string nodeId, string displayName)
        {
            string type = dataValue.WrappedValue.TypeInfo.BuiltInType.ToString();

            if (dataValue.WrappedValue.TypeInfo.ValueRank >= 0)
                type += "[]";


            var measurement = new Measurement()
            {
                time = dataValue.SourceTimestamp,
                value = dataValue.WrappedValue.ToString()
            };


            if (!context.Items.Any(i => i.nodeId == nodeId))
            {
                var monitoredItem = new Item
                {
                    nodeId = nodeId,
                    displayName = displayName,
                    dataType = type,
                    measurements = new List<Measurement>()
                };

                monitoredItem.measurements.Add(measurement);
                context.Items.Add(monitoredItem);
            }
            else
            {
                Item monitoredItem = context.Items.FirstOrDefault(i => i.nodeId == nodeId);
                monitoredItem.measurements.Add(measurement);
            }
            context.SaveChanges();
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
                print = true;
                if (session == null || !session.Connected)
                {
                    return;
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

                    permToSave = true;
                    parent.stopMonitoring = false;
                    lineChart.Visible = true;
                    btnResume.Enabled = false;

                    this.nodeId = rd.NodeId.ToString();
                    this.displayName = rd.DisplayName.ToString();

                    if (context == null)
                        context = new MBase();


                    this.timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                }

                UpdateParent();
                treeServer.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

            parent.stopMonitoring = true;
            //context.Database.ExecuteSqlCommand("Delete from Measurements");
            this.print = true;
            treeServer.SelectedNode = null;
            treeServer.Enabled = true;
            timer = null;
            //this.permToSave = false;
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
        private void timer_Tick(object sender, EventArgs e)
        {
            //refresh here...
            if (!parent.stopMonitoring)
            {
                AddToDB(this.reader.ReadTag(this.nodeId)[0], this.nodeId, this.displayName);

                var itemDB = context.Items.Single(i => i.nodeId == this.nodeId);
                var measurements = context.Measurements.Where(m => m.monitoredId == itemDB.ID).ToList();
                DrawChart(measurements, itemDB.displayName);
                UpdateParent();
            }
        }      
        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.csv"));
        }
        #endregion
    }
}
