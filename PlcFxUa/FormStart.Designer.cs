
namespace PlcFxUa
{
    partial class FormStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPID = new System.Windows.Forms.Button();
            this.MenuCalling = new System.Windows.Forms.Button();
            this.menuData = new System.Windows.Forms.Button();
            this.menuMonitor = new System.Windows.Forms.Button();
            this.menuBrowse = new System.Windows.Forms.Button();
            this.menuConnect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.connectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.menuPID);
            this.panel1.Controls.Add(this.MenuCalling);
            this.panel1.Controls.Add(this.menuData);
            this.panel1.Controls.Add(this.menuMonitor);
            this.panel1.Controls.Add(this.menuBrowse);
            this.panel1.Controls.Add(this.menuConnect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 568);
            this.panel1.TabIndex = 10;
            // 
            // menuPID
            // 
            this.menuPID.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPID.Location = new System.Drawing.Point(0, 400);
            this.menuPID.Name = "menuPID";
            this.menuPID.Size = new System.Drawing.Size(308, 65);
            this.menuPID.TabIndex = 18;
            this.menuPID.Text = "PID";
            this.menuPID.UseVisualStyleBackColor = true;
            this.menuPID.Click += new System.EventHandler(this.menuPID_Click);
            // 
            // MenuCalling
            // 
            this.MenuCalling.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCalling.Location = new System.Drawing.Point(0, 337);
            this.MenuCalling.Name = "MenuCalling";
            this.MenuCalling.Size = new System.Drawing.Size(308, 63);
            this.MenuCalling.TabIndex = 16;
            this.MenuCalling.Text = "Call Methods";
            this.MenuCalling.UseVisualStyleBackColor = true;
            this.MenuCalling.Click += new System.EventHandler(this.MenuCalling_Click);
            // 
            // menuData
            // 
            this.menuData.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuData.Location = new System.Drawing.Point(0, 273);
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(308, 64);
            this.menuData.TabIndex = 12;
            this.menuData.Text = "Data";
            this.menuData.UseVisualStyleBackColor = true;
            this.menuData.Click += new System.EventHandler(this.menuData_Click);
            // 
            // menuMonitor
            // 
            this.menuMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuMonitor.Location = new System.Drawing.Point(0, 200);
            this.menuMonitor.Name = "menuMonitor";
            this.menuMonitor.Size = new System.Drawing.Size(308, 73);
            this.menuMonitor.TabIndex = 17;
            this.menuMonitor.Text = "Monitor";
            this.menuMonitor.UseVisualStyleBackColor = true;
            this.menuMonitor.Click += new System.EventHandler(this.menuMonitor_Click);
            // 
            // menuBrowse
            // 
            this.menuBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBrowse.Location = new System.Drawing.Point(0, 131);
            this.menuBrowse.Name = "menuBrowse";
            this.menuBrowse.Size = new System.Drawing.Size(308, 69);
            this.menuBrowse.TabIndex = 14;
            this.menuBrowse.Text = "Browse / Subscribe";
            this.menuBrowse.UseVisualStyleBackColor = true;
            this.menuBrowse.Click += new System.EventHandler(this.menuBrowse_Click);
            // 
            // menuConnect
            // 
            this.menuConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuConnect.Location = new System.Drawing.Point(0, 75);
            this.menuConnect.Name = "menuConnect";
            this.menuConnect.Size = new System.Drawing.Size(308, 56);
            this.menuConnect.TabIndex = 11;
            this.menuConnect.Text = "Connection";
            this.menuConnect.UseVisualStyleBackColor = true;
            this.menuConnect.Click += new System.EventHandler(this.menuConnect_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 75);
            this.panel2.TabIndex = 11;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.statusStrip);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(308, 538);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(698, 30);
            this.panelStatus.TabIndex = 11;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionLabel,
            this.operationLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 4);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 26);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // connectionLabel
            // 
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(151, 20);
            this.connectionLabel.Text = "toolStripStatusLabel1";
            // 
            // operationLabel
            // 
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(151, 20);
            this.operationLabel.Text = "toolStripStatusLabel1";
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(308, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(698, 538);
            this.panelChild.TabIndex = 12;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 568);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel1);
            this.Name = "FormStart";
            this.Text = "PLC-OPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuData;
        private System.Windows.Forms.Button menuConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuCalling;
        private System.Windows.Forms.Button menuBrowse;
        private System.Windows.Forms.Panel panelStatus;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel connectionLabel;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button menuMonitor;
        public System.Windows.Forms.ToolStripStatusLabel operationLabel;
        private System.Windows.Forms.Button menuPID;
    }
}

