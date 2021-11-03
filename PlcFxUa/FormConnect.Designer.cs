
namespace PlcFxUa
{
    partial class FormConnect
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
            this.TextConn = new System.Windows.Forms.Label();
            this.BtnEditUrl = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.EditUrl = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextConn
            // 
            this.TextConn.AutoSize = true;
            this.TextConn.Location = new System.Drawing.Point(390, 135);
            this.TextConn.Name = "TextConn";
            this.TextConn.Size = new System.Drawing.Size(46, 17);
            this.TextConn.TabIndex = 17;
            this.TextConn.Text = "label1";
            // 
            // BtnEditUrl
            // 
            this.BtnEditUrl.Location = new System.Drawing.Point(176, 60);
            this.BtnEditUrl.Name = "BtnEditUrl";
            this.BtnEditUrl.Size = new System.Drawing.Size(58, 23);
            this.BtnEditUrl.TabIndex = 15;
            this.BtnEditUrl.Text = "Edit";
            this.BtnEditUrl.UseVisualStyleBackColor = true;
            this.BtnEditUrl.Click += new System.EventHandler(this.BtnEditUrl_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(468, 60);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(102, 23);
            this.BtnDisconnect.TabIndex = 14;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click_1);
            // 
            // EditUrl
            // 
            this.EditUrl.Location = new System.Drawing.Point(176, 32);
            this.EditUrl.Name = "EditUrl";
            this.EditUrl.ReadOnly = true;
            this.EditUrl.Size = new System.Drawing.Size(273, 22);
            this.EditUrl.TabIndex = 13;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(468, 31);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(102, 23);
            this.BtnConnect.TabIndex = 12;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextConn);
            this.Controls.Add(this.BtnEditUrl);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.EditUrl);
            this.Controls.Add(this.BtnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnect";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextConn;
        private System.Windows.Forms.Button BtnEditUrl;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.TextBox EditUrl;
        private System.Windows.Forms.Button BtnConnect;
    }
}