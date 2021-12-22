
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
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
            this.databaseBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
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
            this.panel1.Size = new System.Drawing.Size(300, 630);
            this.panel1.TabIndex = 10;
            // 
            // menuPID
            // 
            this.menuPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.menuPID.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuPID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuPID.ForeColor = System.Drawing.Color.White;
            this.menuPID.Location = new System.Drawing.Point(0, 465);
            this.menuPID.Name = "menuPID";
            this.menuPID.Size = new System.Drawing.Size(300, 75);
            this.menuPID.TabIndex = 18;
            this.menuPID.Text = "PID";
            this.menuPID.UseVisualStyleBackColor = false;
            this.menuPID.Click += new System.EventHandler(this.menuPID_Click);
            // 
            // MenuCalling
            // 
            this.MenuCalling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.MenuCalling.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuCalling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuCalling.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuCalling.ForeColor = System.Drawing.Color.White;
            this.MenuCalling.Location = new System.Drawing.Point(0, 390);
            this.MenuCalling.Name = "MenuCalling";
            this.MenuCalling.Size = new System.Drawing.Size(300, 75);
            this.MenuCalling.TabIndex = 16;
            this.MenuCalling.Text = "Call Methods";
            this.MenuCalling.UseVisualStyleBackColor = false;
            this.MenuCalling.Click += new System.EventHandler(this.MenuCalling_Click);
            // 
            // menuData
            // 
            this.menuData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.menuData.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuData.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuData.ForeColor = System.Drawing.Color.White;
            this.menuData.Location = new System.Drawing.Point(0, 315);
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(300, 75);
            this.menuData.TabIndex = 12;
            this.menuData.Text = "Data";
            this.menuData.UseVisualStyleBackColor = false;
            this.menuData.Click += new System.EventHandler(this.menuData_Click);
            // 
            // menuMonitor
            // 
            this.menuMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.menuMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuMonitor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuMonitor.ForeColor = System.Drawing.Color.White;
            this.menuMonitor.Location = new System.Drawing.Point(0, 240);
            this.menuMonitor.Name = "menuMonitor";
            this.menuMonitor.Size = new System.Drawing.Size(300, 75);
            this.menuMonitor.TabIndex = 17;
            this.menuMonitor.Text = "Monitor";
            this.menuMonitor.UseVisualStyleBackColor = false;
            this.menuMonitor.Click += new System.EventHandler(this.menuMonitor_Click);
            // 
            // menuBrowse
            // 
            this.menuBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.menuBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuBrowse.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuBrowse.ForeColor = System.Drawing.Color.White;
            this.menuBrowse.Location = new System.Drawing.Point(0, 165);
            this.menuBrowse.Name = "menuBrowse";
            this.menuBrowse.Size = new System.Drawing.Size(300, 75);
            this.menuBrowse.TabIndex = 14;
            this.menuBrowse.Text = "Browse / Subscribe";
            this.menuBrowse.UseVisualStyleBackColor = false;
            this.menuBrowse.Click += new System.EventHandler(this.menuBrowse_Click);
            // 
            // menuConnect
            // 
            this.menuConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.menuConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuConnect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuConnect.ForeColor = System.Drawing.Color.White;
            this.menuConnect.Location = new System.Drawing.Point(0, 90);
            this.menuConnect.Margin = new System.Windows.Forms.Padding(5);
            this.menuConnect.Name = "menuConnect";
            this.menuConnect.Size = new System.Drawing.Size(300, 75);
            this.menuConnect.TabIndex = 11;
            this.menuConnect.Text = "Connection";
            this.menuConnect.UseVisualStyleBackColor = false;
            this.menuConnect.Click += new System.EventHandler(this.menuConnect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 90);
            this.panel2.TabIndex = 11;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.statusStrip);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(300, 600);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(1400, 30);
            this.panelStatus.TabIndex = 11;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionLabel,
            this.operationLabel,
            this.databaseBtn});
            this.statusStrip.Location = new System.Drawing.Point(0, 4);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1400, 26);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // connectionLabel
            // 
            this.connectionLabel.ForeColor = System.Drawing.Color.White;
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(151, 20);
            this.connectionLabel.Text = "toolStripStatusLabel1";
            // 
            // operationLabel
            // 
            this.operationLabel.ForeColor = System.Drawing.Color.White;
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(151, 20);
            this.operationLabel.Text = "toolStripStatusLabel1";
            // 
            // databaseBtn
            // 
            this.databaseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.databaseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.databaseBtn.Image = global::PlcFxUa.Properties.Resources.delete_database_32;
            this.databaseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(39, 24);
            this.databaseBtn.Text = "toolStripSplitButton1";
            this.databaseBtn.ToolTipText = "Delete from database";
            this.databaseBtn.ButtonClick += new System.EventHandler(this.databaseBtn_ButtonClick);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelChild.Location = new System.Drawing.Point(300, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1400, 600);
            this.panelChild.TabIndex = 12;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1700, 630);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "OPC UA Client";
            this.Load += new System.EventHandler(this.FormStart_Load);
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
        private System.Windows.Forms.ToolStripSplitButton databaseBtn;
    }
}

