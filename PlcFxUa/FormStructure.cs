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

namespace PlcFxUa
{
    public partial class FormStructure : Form
    {
        private FormStart parent;
        private Session session;
        public FormStructure()
        {
            InitializeComponent();
        }
        public FormStructure(FormStart formStart, Session mainSession)
        {
            this.parent = formStart;
            this.session = mainSession;
        }
    }
}
