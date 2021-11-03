
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
            this.menuData = new System.Windows.Forms.Button();
            this.MenuCalling = new System.Windows.Forms.Button();
            this.subStruct = new System.Windows.Forms.Button();
            this.subVariables = new System.Windows.Forms.Button();
            this.menuMonitor = new System.Windows.Forms.Button();
            this.menuBrowse = new System.Windows.Forms.Button();
            this.menuStart = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.menuData);
            this.panel1.Controls.Add(this.MenuCalling);
            this.panel1.Controls.Add(this.subStruct);
            this.panel1.Controls.Add(this.subVariables);
            this.panel1.Controls.Add(this.menuMonitor);
            this.panel1.Controls.Add(this.menuBrowse);
            this.panel1.Controls.Add(this.menuStart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 568);
            this.panel1.TabIndex = 10;
            // 
            // menuData
            // 
            this.menuData.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuData.Location = new System.Drawing.Point(0, 440);
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(308, 64);
            this.menuData.TabIndex = 12;
            this.menuData.Text = "Data";
            this.menuData.UseVisualStyleBackColor = true;
            this.menuData.Click += new System.EventHandler(this.menuData_Click);
            // 
            // MenuCalling
            // 
            this.MenuCalling.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCalling.Location = new System.Drawing.Point(0, 377);
            this.MenuCalling.Name = "MenuCalling";
            this.MenuCalling.Size = new System.Drawing.Size(308, 63);
            this.MenuCalling.TabIndex = 16;
            this.MenuCalling.Text = "Call Methods";
            this.MenuCalling.UseVisualStyleBackColor = true;
            this.MenuCalling.Click += new System.EventHandler(this.MenuCalling_Click);
            // 
            // subStruct
            // 
            this.subStruct.Dock = System.Windows.Forms.DockStyle.Top;
            this.subStruct.Location = new System.Drawing.Point(0, 312);
            this.subStruct.Name = "subStruct";
            this.subStruct.Size = new System.Drawing.Size(308, 65);
            this.subStruct.TabIndex = 18;
            this.subStruct.Text = "Structure";
            this.subStruct.UseVisualStyleBackColor = true;
            this.subStruct.Click += new System.EventHandler(this.subStruct_Click);
            // 
            // subVariables
            // 
            this.subVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.subVariables.Location = new System.Drawing.Point(0, 259);
            this.subVariables.Name = "subVariables";
            this.subVariables.Size = new System.Drawing.Size(308, 53);
            this.subVariables.TabIndex = 17;
            this.subVariables.Text = "Variables";
            this.subVariables.UseVisualStyleBackColor = true;
            this.subVariables.Click += new System.EventHandler(this.subMonitorValues_Click);
            // 
            // menuMonitor
            // 
            this.menuMonitor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuMonitor.Location = new System.Drawing.Point(0, 200);
            this.menuMonitor.Name = "menuMonitor";
            this.menuMonitor.Size = new System.Drawing.Size(308, 59);
            this.menuMonitor.TabIndex = 12;
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
            // menuStart
            // 
            this.menuStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStart.Location = new System.Drawing.Point(0, 75);
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(308, 56);
            this.menuStart.TabIndex = 11;
            this.menuStart.Text = "Connection";
            this.menuStart.UseVisualStyleBackColor = true;
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
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
        private System.Windows.Forms.Button menuMonitor;
        private System.Windows.Forms.Button menuStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuCalling;
        private System.Windows.Forms.Button menuBrowse;
        private System.Windows.Forms.Panel panelStatus;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel connectionLabel;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button subVariables;
        public System.Windows.Forms.ToolStripStatusLabel operationLabel;
        private System.Windows.Forms.Button subStruct;
    }
}

