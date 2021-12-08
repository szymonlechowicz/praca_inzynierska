
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
            this.BtnEditUrl = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.EditUrl = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditUrl
            // 
            this.BtnEditUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.BtnEditUrl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditUrl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEditUrl.ForeColor = System.Drawing.Color.White;
            this.BtnEditUrl.Location = new System.Drawing.Point(22, 64);
            this.BtnEditUrl.Name = "BtnEditUrl";
            this.BtnEditUrl.Size = new System.Drawing.Size(78, 32);
            this.BtnEditUrl.TabIndex = 15;
            this.BtnEditUrl.Text = "Edit";
            this.BtnEditUrl.UseVisualStyleBackColor = false;
            this.BtnEditUrl.Click += new System.EventHandler(this.BtnEditUrl_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.AutoSize = true;
            this.BtnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.BtnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDisconnect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDisconnect.ForeColor = System.Drawing.Color.White;
            this.BtnDisconnect.Location = new System.Drawing.Point(671, 65);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(122, 34);
            this.BtnDisconnect.TabIndex = 14;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click_1);
            // 
            // EditUrl
            // 
            this.EditUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditUrl.Location = new System.Drawing.Point(22, 15);
            this.EditUrl.Name = "EditUrl";
            this.EditUrl.ReadOnly = true;
            this.EditUrl.Size = new System.Drawing.Size(592, 26);
            this.EditUrl.TabIndex = 13;
            this.EditUrl.TextChanged += new System.EventHandler(this.EditUrl_TextChanged);
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(671, 15);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(122, 34);
            this.BtnConnect.TabIndex = 12;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 294);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.BtnConnect);
            this.panel2.Controls.Add(this.BtnDisconnect);
            this.panel2.Controls.Add(this.BtnEditUrl);
            this.panel2.Controls.Add(this.EditUrl);
            this.panel2.Location = new System.Drawing.Point(166, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 102);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PlcFxUa.Properties.Resources.opc_ua_png;
            this.pictureBox1.Location = new System.Drawing.Point(236, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnect";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEditUrl;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.TextBox EditUrl;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}