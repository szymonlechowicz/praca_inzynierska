
namespace PlcFxUa
{
    partial class FormStructure
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
            this.structureLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.Location = new System.Drawing.Point(12, 12);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(325, 426);
            this.treeServer.TabIndex = 3;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // structureLV
            // 
            this.structureLV.HideSelection = false;
            this.structureLV.Location = new System.Drawing.Point(373, 3);
            this.structureLV.Name = "structureLV";
            this.structureLV.Size = new System.Drawing.Size(389, 435);
            this.structureLV.TabIndex = 4;
            this.structureLV.UseCompatibleStateImageBehavior = false;
            this.structureLV.Visible = false;
            // 
            // FormStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.structureLV);
            this.Controls.Add(this.treeServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStructure";
            this.Text = "FormStructure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.ListView structureLV;
    }
}