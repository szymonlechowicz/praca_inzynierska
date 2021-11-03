
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
            this.MonitorLabel = new System.Windows.Forms.Label();
            this.treeServer = new System.Windows.Forms.TreeView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.WriteTextBox = new System.Windows.Forms.TextBox();
            this.MonitoredItemsView = new System.Windows.Forms.DataGridView();
            this.ColClose = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColNodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColWrite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MonitoredItemsView)).BeginInit();
            this.SuspendLayout();
            // 
            // MonitorLabel
            // 
            this.MonitorLabel.AutoSize = true;
            this.MonitorLabel.Location = new System.Drawing.Point(366, 55);
            this.MonitorLabel.Name = "MonitorLabel";
            this.MonitorLabel.Size = new System.Drawing.Size(90, 17);
            this.MonitorLabel.TabIndex = 1;
            this.MonitorLabel.Text = "MonitorLabel";
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.Location = new System.Drawing.Point(21, 12);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(325, 426);
            this.treeServer.TabIndex = 2;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(366, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "label1";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(369, 105);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.Location = new System.Drawing.Point(468, 105);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(100, 22);
            this.WriteTextBox.TabIndex = 5;
            this.WriteTextBox.Visible = false;
            this.WriteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WriteTextBox_KeyDown);
            // 
            // MonitoredItemsView
            // 
            this.MonitoredItemsView.AllowUserToResizeColumns = false;
            this.MonitoredItemsView.AllowUserToResizeRows = false;
            this.MonitoredItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonitoredItemsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColClose,
            this.ColNodeId,
            this.ColValue,
            this.ColType,
            this.ColModify,
            this.ColWrite});
            this.MonitoredItemsView.Location = new System.Drawing.Point(378, 201);
            this.MonitoredItemsView.Name = "MonitoredItemsView";
            this.MonitoredItemsView.RowHeadersVisible = false;
            this.MonitoredItemsView.RowHeadersWidth = 51;
            this.MonitoredItemsView.RowTemplate.Height = 24;
            this.MonitoredItemsView.Size = new System.Drawing.Size(750, 211);
            this.MonitoredItemsView.TabIndex = 6;
            this.MonitoredItemsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonitoredItemsView_CellContentClick);
            // 
            // ColClose
            // 
            this.ColClose.HeaderText = "";
            this.ColClose.MinimumWidth = 6;
            this.ColClose.Name = "ColClose";
            this.ColClose.ReadOnly = true;
            this.ColClose.Width = 125;
            // 
            // ColNodeId
            // 
            this.ColNodeId.HeaderText = "Node ID";
            this.ColNodeId.MinimumWidth = 6;
            this.ColNodeId.Name = "ColNodeId";
            this.ColNodeId.ReadOnly = true;
            this.ColNodeId.Width = 125;
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Value";
            this.ColValue.MinimumWidth = 6;
            this.ColValue.Name = "ColValue";
            this.ColValue.ReadOnly = true;
            this.ColValue.Width = 125;
            // 
            // ColType
            // 
            this.ColType.HeaderText = "Data Type";
            this.ColType.MinimumWidth = 6;
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.Width = 125;
            // 
            // ColModify
            // 
            this.ColModify.HeaderText = "";
            this.ColModify.MinimumWidth = 6;
            this.ColModify.Name = "ColModify";
            this.ColModify.Text = "Modify";
            this.ColModify.UseColumnTextForButtonValue = true;
            this.ColModify.Width = 125;
            // 
            // ColWrite
            // 
            this.ColWrite.HeaderText = "Write Value";
            this.ColWrite.MinimumWidth = 6;
            this.ColWrite.Name = "ColWrite";
            this.ColWrite.ReadOnly = true;
            this.ColWrite.Width = 125;
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 450);
            this.Controls.Add(this.MonitoredItemsView);
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.treeServer);
            this.Controls.Add(this.MonitorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMonitor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MonitoredItemsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MonitorLabel;
        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox WriteTextBox;
        private System.Windows.Forms.DataGridView MonitoredItemsView;
        private System.Windows.Forms.DataGridViewImageColumn ColClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNodeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewButtonColumn ColModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWrite;
    }
}