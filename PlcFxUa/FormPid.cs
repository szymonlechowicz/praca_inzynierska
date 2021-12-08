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
        private Writer writer;

        public FormPid(FormStart formStart, Session mainSession, MBase mainContext)
        {
            InitializeComponent();

            helpLabel.Text = "";
            this.parent = formStart;
            this.session = mainSession;
            if (this.session != null)
            {
                this.writer = new Writer(this.session, this.parent);
            }

            this.context = mainContext;

            settingIds[0] = "ns=2;i=10220";
            settingNames[0] = "UInt16Value";

            settingIds[1] = "ns=2;i=10222";
            settingNames[1] = "UInt32Value";

            settingIds[2] = "ns=2;i=10848";
            settingNames[2] = "UInt16Value";

            settingIds[3] = "ns=2;i=10850";
            settingNames[3] = "UInt32Value";

            settingIds[4] = "ns=2;i=10852";
            settingNames[4] = "UInt64Value";

            settingIds[5] = "ns=2;i=10224";
            settingNames[5] = "UInt64Value";

            dataIds[0] = "ns=2;i=10850";
            dataNames[0] = "UInt32Value";

            dataIds[1] = "ns=2;i=10852";
            dataNames[1] = "UInt64Value";


            //settingIds[0] = "ns=4;i=44";
            //settingNames[0] = "InputLowerLimit";

            //settingIds[1] = "ns=4;i=45";
            //settingNames[1] = "InputUpperLimit";

            //settingIds[2] = "ns=4;i=103";
            //settingNames[2] = "Gain";

            //settingIds[3] = "ns=4;i=104";
            //settingNames[3] = "Ti";

            //settingIds[4] = "ns=4;i=105";
            //settingNames[4] = "Td";

            //settingIds[5] = "ns=4;i=129";
            //settingNames[5] = "wartosc_zadana";

            //dataIds[0] = "ns=4;i=130";
            //dataNames[0] = "scaled_input";

            //dataIds[1] = "ns=4;i=131";
            //dataNames[1] = "real_output";

            //for (int i = 0; i < 6; i++)
            //{
            //    settingIds[i] = "";
            //    settingNames[i] = "";
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    dataIds[i] = "";
            //    dataNames[i] = "";
            //}


        }
        #region Control Events
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
            dataValues = ReadTags(this.settingIds);

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
            try
            {
                print = true;
                if (context == null)
                    context = new MBase();

                var item = new MonitoredItem()
                {
                    DisplayName = dataIds[0],
                    StartNodeId = dataNames[0]
                };
                item.Notification += OnNotification;
                subscription.AddItem(item);


                //var item2 = new MonitoredItem()
                //{
                //    DisplayName = dataIds[1],
                //    StartNodeId = dataNames[1]
                //};
                //item2.Notification += OnNotification;
                //subscription.AddItem(item2);


                subscription.ApplyChanges();
                UpdateParent();

                maxTB.Enabled = false;
                minTB.Enabled = false;
                tiTB.Enabled = false;
                xpTB.Enabled = false;
                tdTB.Enabled = false;
                kTB.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }   
        }

        private void maxTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(0, maxTB);
            }
        }


        private void minTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(1, minTB);

            }
        }
        
        private void kTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(2, kTB);
            }
        }

        private void tiTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(3, tiTB);
            }
        }

        private void tdTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(4, tdTB);
            }
        }

        private void xpTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WriteAndRead(5, xpTB);
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            this.print = false;
            btnResume.Enabled = true;
            btnPause.Enabled = false;

            maxTB.Enabled = true;
            minTB.Enabled = true;
            tiTB.Enabled = true;
            xpTB.Enabled = true;
            tdTB.Enabled = true;
            kTB.Enabled = true;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            this.print = true;
            btnPause.Enabled = true;
            btnResume.Enabled = false;

            maxTB.Enabled = false;
            minTB.Enabled = false;
            tiTB.Enabled = false;
            xpTB.Enabled = false;
            tdTB.Enabled = false;
            kTB.Enabled = false;
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
        #endregion
        private ReadValueId AddNode(string nodeId)
        {
            ReadValueId readValue = new ReadValueId();
            readValue.NodeId = nodeId;
            readValue.AttributeId = Attributes.Value;

            return readValue;
        }
        private DataValueCollection ReadTags(string[] ids)
        {
            ReadValueIdCollection readValues = new ReadValueIdCollection();
            foreach (var id in ids)
            {
                readValues.Add(AddNode(id));
            }

            return ReadDataValues(readValues);
        }
        private DataValueCollection ReadTag(string id)
        {
            ReadValueIdCollection readValues = new ReadValueIdCollection();
            readValues.Add(AddNode(id));

            return ReadDataValues(readValues);
        }
        private DataValueCollection ReadDataValues(ReadValueIdCollection readValues)
        {
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

                    string nodeId = item.StartNodeId.ToString();
                    string displayName = item.DisplayName;

                    AddToDB(data.Value, nodeId, displayName);

                    var itemDB = context.Items.Single(i => i.nodeId == nodeId);
                    var measurements = context.Measurements.Where(m => m.monitoredId == itemDB.ID).ToList();

                    if (nodeId == dataIds[0])
                        DrawChart(inputChart, measurements, dataNames[0]);
                    else DrawChart(outputChart, measurements, dataNames[1]);
                    UpdateParent();
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
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
        private void DrawChart(Chart chart, List<Measurement> measurements, string seriesName)
        {
            if (print)
            {
                chart.Series.Clear();
                chart.Series.Add(seriesName);
                chart.Series[seriesName].ChartType = SeriesChartType.Line;
                double x;
                foreach (var measurement in measurements)
                {
                    x = (measurement.time.Ticks - measurement.time.Ticks) / 10000000;
                    chart.Series[seriesName].Points.AddXY(x, Convert.ToDouble(measurement.value));
                }
            }
            else return;
        }

        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetDB(context);
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
        private void WriteAndRead(int index, TextBox textBox)
        {
            string nodeToWrite = settingIds[index];
            var item = context.Items.Single(i => i.nodeId == nodeToWrite);

            this.writer.SetWriter(item.dataType, textBox);
            writer.WriteNode(this, nodeToWrite);

            context.Items.Remove(item);
            context.SaveChanges();


            DataValueCollection dataValues = new DataValueCollection();
            dataValues = ReadTag(nodeToWrite);

            textBox.Text = dataValues[0].Value.ToString();

            foreach (var value in dataValues)
            {
                AddToDB(value, settingIds[index], settingNames[index]);
                ++index;
            }

            subscription.ApplyChanges();
            UpdateParent();
        }

        private void runBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (runBtn.Checked)
            {
                try
                {
                    parent.stopMonitoring = false;
                    print = true;
                    if (context == null)
                        context = new MBase();

                    var item = new MonitoredItem()
                    {
                        DisplayName = dataNames[0],
                        StartNodeId = dataIds[0]
                    };
                    item.Notification += OnNotification;
                    subscription.AddItem(item);


                    var item2 = new MonitoredItem()
                    {
                        DisplayName = dataNames[1],
                        StartNodeId = dataIds[1]
                    };
                    item2.Notification += OnNotification;
                    subscription.AddItem(item2);


                    subscription.ApplyChanges();
                    UpdateParent();

                    maxTB.Enabled = false;
                    minTB.Enabled = false;
                    tiTB.Enabled = false;
                    xpTB.Enabled = false;
                    tdTB.Enabled = false;
                    kTB.Enabled = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
                
        }
    }
}
