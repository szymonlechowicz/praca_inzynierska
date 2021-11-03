
namespace PlcFxUa
{
    partial class FormBrowse
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
            this.tableBrowser = new System.Windows.Forms.DataGridView();
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.Location = new System.Drawing.Point(45, 39);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(325, 426);
            this.treeServer.TabIndex = 0;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            this.treeServer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeServer_NodeMouseDoubleClick);
            // 
            // tableBrowser
            // 
            this.tableBrowser.AllowUserToAddRows = false;
            this.tableBrowser.AllowUserToDeleteRows = false;
            this.tableBrowser.AllowUserToResizeColumns = false;
            this.tableBrowser.AllowUserToResizeRows = false;
            this.tableBrowser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.tableBrowser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tableBrowser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tableBrowser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableBrowser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBrowser.Location = new System.Drawing.Point(426, 39);
            this.tableBrowser.Name = "tableBrowser";
            this.tableBrowser.ReadOnly = true;
            this.tableBrowser.RowHeadersWidth = 51;
            this.tableBrowser.RowTemplate.Height = 24;
            this.tableBrowser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableBrowser.Size = new System.Drawing.Size(550, 221);
            this.tableBrowser.TabIndex = 1;
            this.tableBrowser.Visible = false;
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Location = new System.Drawing.Point(423, 338);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(119, 17);
            this.subscriptionLabel.TabIndex = 2;
            this.subscriptionLabel.Text = "subscriptionLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(423, 291);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "label1";
            // 
            // FormBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 518);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.subscriptionLabel);
            this.Controls.Add(this.tableBrowser);
            this.Controls.Add(this.treeServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBrowse";
            this.Text = "FormBrowse";
            ((System.ComponentModel.ISupportInitialize)(this.tableBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.DataGridView tableBrowser;
        private System.Windows.Forms.Label subscriptionLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}