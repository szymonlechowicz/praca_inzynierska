
namespace PlcFxUa
{
    partial class FormMethod
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
            this.btnCall = new System.Windows.Forms.Button();
            this.modifyTB = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.treeServer = new System.Windows.Forms.TreeView();
            this.outputLV = new System.Windows.Forms.ListView();
            this.inputLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Enabled = false;
            this.btnCall.Location = new System.Drawing.Point(495, 170);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 23);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // modifyTB
            // 
            this.modifyTB.Enabled = false;
            this.modifyTB.Location = new System.Drawing.Point(950, 55);
            this.modifyTB.Name = "modifyTB";
            this.modifyTB.Size = new System.Drawing.Size(100, 22);
            this.modifyTB.TabIndex = 6;
            this.modifyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modifyTB_KeyDown);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(964, 83);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.Location = new System.Drawing.Point(12, 12);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(284, 367);
            this.treeServer.TabIndex = 9;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // outputLV
            // 
            this.outputLV.HideSelection = false;
            this.outputLV.Location = new System.Drawing.Point(316, 236);
            this.outputLV.Name = "outputLV";
            this.outputLV.Size = new System.Drawing.Size(603, 143);
            this.outputLV.TabIndex = 5;
            this.outputLV.UseCompatibleStateImageBehavior = false;
            // 
            // inputLV
            // 
            this.inputLV.FullRowSelect = true;
            this.inputLV.HideSelection = false;
            this.inputLV.Location = new System.Drawing.Point(316, 24);
            this.inputLV.Name = "inputLV";
            this.inputLV.Size = new System.Drawing.Size(603, 140);
            this.inputLV.TabIndex = 3;
            this.inputLV.UseCompatibleStateImageBehavior = false;
            this.inputLV.SelectedIndexChanged += new System.EventHandler(this.inputLV_SelectedIndexChanged);
            // 
            // FormMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 423);
            this.Controls.Add(this.treeServer);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.modifyTB);
            this.Controls.Add(this.outputLV);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.inputLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMethod";
            this.Text = "FormMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.TextBox modifyTB;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.ListView outputLV;
        private System.Windows.Forms.ListView inputLV;
    }
}