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
        private Session session;
        private bool connected = false;
        private ApplicationConfiguration config;
        private MBase context;

        public FormStart()
        {
            InitializeComponent();
            connectionLabel.Text = "OPC UA Client";
            operationLabel.Visible = false;
        }

        private Form activeForm = null;
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

        private void menuMonitor_Click(object sender, EventArgs e)
        { 
            
        }
        private void subMonitorValues_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVariables(this, session, context));
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConnect(this, session, connected, config));
        }

        private void menuBrowse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBrowse(this, session));
        }
        private void MenuCalling_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMethod(this, session));
        }

        private void menuData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormData(this, session, context));
        }


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

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (context != null)
            {
                context.Database.ExecuteSqlCommand("Delete from Items");
            }
        }

        
    }
}
