using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Opc.Ua.Client;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace PlcFxUa
{
    public partial class FormStart : Form
    {
        #region Private Fields
        private Session session;
        private bool connected = false;
        private ApplicationConfiguration config;
        private MBase context;

        private Form activeForm = null;
        #endregion

        #region Public Fields
        public bool stopMonitoring = false;
        #endregion

        #region Constructors
        public FormStart()
        {
            InitializeComponent();
            connectionLabel.Text = "OPC UA Client";
            operationLabel.Visible = false;
        }
        #endregion

        #region Private Members
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenIfConnected(Form childForm)
        {
            if (session == null || !session.Connected)
            {
                MessageBox.Show("Not connected to server");
                return;
            }
            else OpenChildForm(childForm);
        }
        #endregion

        #region Event Handlers
        private void menuConnect_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConnect(this, session, connected, config));
        }

        private void menuMonitor_Click(object sender, EventArgs e)
        {
            OpenIfConnected(new FormMonitor(this, session, context));
        }

        private void menuPID_Click(object sender, EventArgs e)
        {
            OpenIfConnected(new FormPid(this, session, context));
        }
        private void menuBrowse_Click(object sender, EventArgs e)
        {
            OpenIfConnected(new FormBrowse(this, session));
        }
        private void MenuCalling_Click(object sender, EventArgs e)
        {
            OpenIfConnected(new FormMethod(this, session));
        }

        private void menuData_Click(object sender, EventArgs e)
        {
            OpenIfConnected(new FormData(this, session, context));
        }
        private void databaseBtn_ButtonClick(object sender, EventArgs e)
        {
            stopMonitoring = true;
            if (context != null)
            {
                context.Database.ExecuteSqlCommand("Delete from Items");
                context.Database.ExecuteSqlCommand("Delete from Measurements");
                MessageBox.Show("Database clear");
            }
            else MessageBox.Show("No context");
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormConnect(this, session, connected, config));
        }
        #endregion

        #region Public Interface
        public void GetSession(Session newSession)
        {
            this.session = newSession;
        }

        public void GetBool(bool newConnected)
        {
            this.connected = newConnected;
        }
        public void GetConfig(ApplicationConfiguration newConfig)
        {
            this.config = newConfig;
        }
        public void GetDB(MBase newContext)
        {
            this.context = newContext;
        }
        #endregion
    }
}
