
namespace PlcFxUa
{
    partial class FormMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeServer = new System.Windows.Forms.TreeView();
            this.btnModify = new System.Windows.Forms.Button();
            this.WriteTextBox = new System.Windows.Forms.TextBox();
            this.ItemsView = new System.Windows.Forms.DataGridView();
            this.ColClose = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.BackColor = System.Drawing.Color.White;
            this.treeServer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeServer.Location = new System.Drawing.Point(25, 25);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(300, 450);
            this.treeServer.TabIndex = 2;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnModify.Enabled = false;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(227, 507);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 28);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WriteTextBox.Enabled = false;
            this.WriteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WriteTextBox.Location = new System.Drawing.Point(25, 507);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(204, 26);
            this.WriteTextBox.TabIndex = 5;
            this.WriteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WriteTextBox_KeyDown);
            // 
            // ItemsView
            // 
            this.ItemsView.AllowUserToAddRows = false;
            this.ItemsView.AllowUserToDeleteRows = false;
            this.ItemsView.AllowUserToResizeColumns = false;
            this.ItemsView.AllowUserToResizeRows = false;
            this.ItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColClose});
            this.ItemsView.Location = new System.Drawing.Point(360, 119);
            this.ItemsView.MaximumSize = new System.Drawing.Size(900, 450);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.ReadOnly = true;
            this.ItemsView.RowHeadersVisible = false;
            this.ItemsView.RowHeadersWidth = 51;
            this.ItemsView.RowTemplate.Height = 24;
            this.ItemsView.Size = new System.Drawing.Size(185, 10);
            this.ItemsView.TabIndex = 6;
            this.ItemsView.Visible = false;
            this.ItemsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsView_CellContentClick);
            // 
            // ColClose
            // 
            this.ColClose.HeaderText = "";
            this.ColClose.MinimumWidth = 6;
            this.ColClose.Name = "ColClose";
            this.ColClose.ReadOnly = true;
            this.ColClose.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 600);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(360, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 96);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "label";
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ItemsView);
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.treeServer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonitor";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.FormMonitor_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox WriteTextBox;
        private System.Windows.Forms.DataGridView ItemsView;
        private System.Windows.Forms.DataGridViewImageColumn ColClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}