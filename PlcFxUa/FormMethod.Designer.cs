
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
            this.btnCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnCall.Enabled = false;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCall.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCall.ForeColor = System.Drawing.Color.White;
            this.btnCall.Location = new System.Drawing.Point(400, 242);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(83, 31);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // modifyTB
            // 
            this.modifyTB.Enabled = false;
            this.modifyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modifyTB.Location = new System.Drawing.Point(758, 244);
            this.modifyTB.Name = "modifyTB";
            this.modifyTB.Size = new System.Drawing.Size(123, 26);
            this.modifyTB.TabIndex = 6;
            this.modifyTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modifyTB_KeyDown);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnModify.Enabled = false;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(878, 242);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(83, 31);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // treeServer
            // 
            this.treeServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.treeServer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeServer.Location = new System.Drawing.Point(25, 25);
            this.treeServer.Name = "treeServer";
            this.treeServer.Size = new System.Drawing.Size(300, 550);
            this.treeServer.TabIndex = 9;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // outputLV
            // 
            this.outputLV.HideSelection = false;
            this.outputLV.Location = new System.Drawing.Point(400, 294);
            this.outputLV.Name = "outputLV";
            this.outputLV.Size = new System.Drawing.Size(555, 281);
            this.outputLV.TabIndex = 5;
            this.outputLV.UseCompatibleStateImageBehavior = false;
            // 
            // inputLV
            // 
            this.inputLV.FullRowSelect = true;
            this.inputLV.HideSelection = false;
            this.inputLV.Location = new System.Drawing.Point(400, 25);
            this.inputLV.Name = "inputLV";
            this.inputLV.Size = new System.Drawing.Size(555, 193);
            this.inputLV.TabIndex = 3;
            this.inputLV.UseCompatibleStateImageBehavior = false;
            this.inputLV.SelectedIndexChanged += new System.EventHandler(this.inputLV_SelectedIndexChanged);
            // 
            // FormMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
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