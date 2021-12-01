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
    public partial class FormPid : Form
    {
        private FormStart parent;
        private Session session;
        private MBase context;
        private Subscription subscription;
        private string[] settingIds = new string[6];
        private string[] settingNames = new string[6];
        private string[] dataIds = new string[2];
        private string[] dataNames = new string[2];
        private bool print;

        public FormPid()
        {
            InitializeComponent();
        }
        public FormPid(FormStart formStart, Session mainSession, MBase mainContext)
        {
            InitializeComponent();

            this.parent = formStart;
            this.session = mainSession;
            this.context = mainContext;
            
            for (int i = 0; i < 6; i++)
            {
                settingIds[i] = "";
                settingNames[i] = "";
            }
            for (int i = 0; i < 2; i++)
            {
                dataIds[i] = "";
                dataNames[i] = "";
            }
        }

        private void FormPid_Load(object sender, EventArgs e)
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

            if (context == null)
                context = new MBase();


            DataValueCollection dataValues = new DataValueCollection();
            dataValues = ReadTags();

            maxTB.Text = dataValues[0].Value.ToString();
            minTB.Text = dataValues[1].Value.ToString();
            kTB.Text = dataValues[2].Value.ToString();
            tiTB.Text = dataValues[3].Value.ToString();
            tdTB.Text = dataValues[4].Value.ToString();
            xpTB.Text = dataValues[5].Value.ToString();
            
            
            int index = 0;
            foreach (var value in dataValues)
            {
                AddToDB(value, settingIds[index], settingNames[index]);
                ++index;
            }

            subscription.ApplyChanges();
            UpdateParent();
        }
        private void runBtn_Click(object sender, EventArgs e)
        {
            print = true;
            if (context == null)
                context = new MBase();

            for (int i = 0; i < 2; i++)
            {
                var item = new MonitoredItem()
                {
                    DisplayName = dataIds[i],
                    StartNodeId = dataNames[i]
                };
                item.Notification += OnNotification;
                subscription.AddItem(item);
            }

            subscription.ApplyChanges();
            UpdateParent();
        }

        private ReadValueId AddNode(string nodeId)
        {
            ReadValueId readValue = new ReadValueId();
            readValue.NodeId = nodeId;
            readValue.AttributeId = Attributes.Value;

            return readValue;
        }
        private DataValueCollection ReadTags()
        {
            ReadValueIdCollection readValues = new ReadValueIdCollection();
            readValues.Add(AddNode(settingIds[0]));
            readValues.Add(AddNode(settingIds[1]));
            readValues.Add(AddNode(settingIds[2]));
            readValues.Add(AddNode(settingIds[3]));
            readValues.Add(AddNode(settingIds[4]));
            readValues.Add(AddNode(settingIds[5]));

            DataValueCollection results = null;
            DiagnosticInfoCollection diagnosticInfos = null;

            this.session.Read(null, Double.MaxValue, TimestampsToReturn.Both, readValues, out results, out diagnosticInfos);
            
            ClientBase.ValidateResponse(results, readValues);
            ClientBase.ValidateDiagnosticInfos(diagnosticInfos, readValues);

            if (DataValue.IsBad(results[0]))
            {
                throw new ServiceResultException("Error");
            }

            DialogResult = DialogResult.OK;

            return results;
        }
        private void OnNotification(MonitoredItem monitoredItem, MonitoredItemNotificationEventArgs e)
        {
            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new MonitoredItemNotificationEventHandler(OnNotification), monitoredItem, e);
                    return;
                }

                MonitoredItemNotification data = e.NotificationValue as MonitoredItemNotification;

                if (data == null) return;
                AddToDB(data.Value, monitoredItem.StartNodeId.ToString(), monitoredItem.DisplayName);
                
                var item = context.Items.Single(i => i.nodeId == monitoredItem.StartNodeId.ToString());
                var measurements = context.Measurements.Where(m => m.monitoredId == item.ID).ToList();
                
                if (monitoredItem.StartNodeId.ToString() == dataIds[0])
                    DrawChart(inputChart, measurements);
                else DrawChart(outputChart, measurements);
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
                context.SaveChanges();
            }
            else
            {
                Item monitoredItem = context.Items.FirstOrDefault(i => i.nodeId == nodeId);
                monitoredItem.measurements.Add(measurement);
                context.SaveChanges();
            }
        }
        private void DrawChart(Chart chart, List<Measurement> measurements)
        {
            if (print)
            {
                chart.Series.Clear();
                chart.Series.Add("Measure");
                chart.Series["Measure"].ChartType = SeriesChartType.Line;
                double x;
                foreach (var measurement in measurements)
                {
                    x = (measurement.time.Ticks - measurement.time.Ticks) / 10000000;
                    chart.Series["Measure"].Points.AddXY(x, Convert.ToDouble(measurement.value));
                }
            }
            
        }

        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            context.Items.Load();
            context.Measurements.Load();
            for (int index = 0; index < 2; index++)
            {
                var item = context.Items.Single(i => i.nodeId == dataIds[index]);
                var measurements = context.Measurements.Where(m => m.monitoredId == item.ID).ToList();

                ExportCSV(measurements, dataNames[index]);
            }
            
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
