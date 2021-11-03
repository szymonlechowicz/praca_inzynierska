
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
            this.MethodTB = new System.Windows.Forms.TextBox();
            this.ObjectTB = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.outputLV = new System.Windows.Forms.ListView();
            this.inputLV = new System.Windows.Forms.ListView();
            this.modifyTB = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.statusLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MethodTB
            // 
            this.MethodTB.Location = new System.Drawing.Point(43, 66);
            this.MethodTB.Name = "MethodTB";
            this.MethodTB.Size = new System.Drawing.Size(219, 22);
            this.MethodTB.TabIndex = 0;
            // 
            // ObjectTB
            // 
            this.ObjectTB.Location = new System.Drawing.Point(43, 170);
            this.ObjectTB.Name = "ObjectTB";
            this.ObjectTB.Size = new System.Drawing.Size(219, 22);
            this.ObjectTB.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(106, 278);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
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
            // modifyTB
            // 
            this.modifyTB.Enabled = false;
            this.modifyTB.Location = new System.Drawing.Point(950, 55);
            this.modifyTB.Name = "modifyTB";
            this.modifyTB.Size = new System.Drawing.Size(100, 22);
            this.modifyTB.TabIndex = 6;
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
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.Location = new System.Drawing.Point(991, 206);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(46, 17);
            this.statusLB.TabIndex = 8;
            this.statusLB.Text = "label1";
            // 
            // FormMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 423);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.modifyTB);
            this.Controls.Add(this.outputLV);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.inputLV);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.ObjectTB);
            this.Controls.Add(this.MethodTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMethod";
            this.Text = "FormMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MethodTB;
        private System.Windows.Forms.TextBox ObjectTB;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.ListView outputLV;
        private System.Windows.Forms.ListView inputLV;
        private System.Windows.Forms.TextBox modifyTB;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label statusLB;
    }
}