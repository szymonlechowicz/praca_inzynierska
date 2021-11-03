using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;

namespace PlcFxUa
{
    public partial class FormChange : Form
    {
        private Session session;
        private Argument argument;
        public FormChange()
        {
            InitializeComponent();
        }
        public FormChange(Session mainSession, Argument clicked)
        {
            InitializeComponent();

            this.session = mainSession;
            this.argument = clicked;
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
        }
    }
}
