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
    public partial class FormConnect : Form
    {
        private static string myUrl = "opc.tcp://localhost:55000";

        private FormStart parent;
        
        public Session session;
        public bool connected = false;
        private ApplicationConfiguration config;

        public FormConnect()
        {
            InitializeComponent();
        }
        public FormConnect(FormStart formStart, Session mainSession, bool mainConnected, ApplicationConfiguration mainConfiguration)
        {
            InitializeComponent();

            BtnConnect.Size = BtnDisconnect.Size;

            this.parent = formStart;
            this.session = mainSession;
            this.connected = mainConnected;
            this.config = mainConfiguration;
            
            EditUrl.Text = myUrl;
            //TreeServer.Nodes.Clear();
            if (!connected) BtnDisconnect.Enabled = false;
        }
       
      

        //private void Populate(string path, TreeNode treeNode)
        //{
        //    try 
        //    {
        //        string[] dirs = Directory.GetDirectories(path);
        //        foreach (string dir in dirs)
        //        {
        //            string[] dirFromPath = dir.Split('\\');
        //            TreeNode node = new TreeNode(dirFromPath[dirFromPath.Length - 1]);
        //            treeNode.Nodes.Add(node);
        //            Populate(dir, node);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        private void Certificate()
        {
            config = new ApplicationConfiguration()
            {
                ApplicationName = "Dissertation",
                ApplicationUri = Utils.Format(@"urn:{0}:Dissertation", System.Net.Dns.GetHostName()),
                ApplicationType = ApplicationType.Client,
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault", SubjectName = "Dissertation" },
                    TrustedIssuerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities" },
                    TrustedPeerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications" },
                    RejectedCertificateStore = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates" },
                    AutoAcceptUntrustedCertificates = true
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                TraceConfiguration = new TraceConfiguration()
            };
            config.Validate(ApplicationType.Client).GetAwaiter().GetResult();
            if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
            }

            var application = new ApplicationInstance
            {
                ApplicationName = "Dissertation",
                ApplicationType = ApplicationType.Client,
                ApplicationConfiguration = config
            };
            application.CheckApplicationInstanceCertificate(false, 2048).GetAwaiter().GetResult();
        }
        private void UpdateStatus(string endpointUrl)
        {
            if (connected)
            {
                parent.connectionLabel.Text = "Connected to " + endpointUrl;
            }
            else
            {
                parent.connectionLabel.Text = "Disconnected";
            }
        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Certificate();

                string url = EditUrl.Text;
                var selectedEndpoint = CoreClientUtils.SelectEndpoint(url, useSecurity: true);

                session = Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)),
                    false, "", 60000, null, null).GetAwaiter().GetResult();

                if (session != null && !connected)
                {
                    connected = true;
                    BtnDisconnect.Enabled = true;
                    UpdateStatus(url);
                    UpdateParent();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnDisconnect_Click_1(object sender, EventArgs e)
        {
            session.Close();
            if (!session.Connected)
            {
                connected = false;
                UpdateStatus(null);
                BtnDisconnect.Enabled = false;
                UpdateParent();

            }
        }

        private void BtnEditUrl_Click(object sender, EventArgs e)
        {
            if (EditUrl.ReadOnly)
                EditUrl.ReadOnly = false;
            else EditUrl.ReadOnly = true;
        }

        
        private void UpdateParent()
        {
            parent.GetSession(session);
            parent.GetBool(connected);
            parent.GetConfig(config);
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            
        }

        private void EditUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
