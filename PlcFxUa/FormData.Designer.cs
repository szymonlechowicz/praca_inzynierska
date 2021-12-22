
namespace PlcFxUa
{
    partial class FormData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeServer = new System.Windows.Forms.TreeView();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.measurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).BeginInit();
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
            this.treeServer.Size = new System.Drawing.Size(300, 550);
            this.treeServer.TabIndex = 3;
            this.treeServer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeServer_BeforeExpand);
            this.treeServer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeServer_AfterSelect);
            // 
            // lineChart
            // 
            this.lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(362, 115);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.lineChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Measurement";
            this.lineChart.Series.Add(series1);
            this.lineChart.Size = new System.Drawing.Size(1013, 460);
            this.lineChart.TabIndex = 8;
            this.lineChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnResume);
            this.panel1.Location = new System.Drawing.Point(1040, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 75);
            this.panel1.TabIndex = 13;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Image = global::PlcFxUa.Properties.Resources.csv_32;
            this.btnOpen.Location = new System.Drawing.Point(270, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(55, 55);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::PlcFxUa.Properties.Resources.save_32;
            this.btnSave.Location = new System.Drawing.Point(205, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 55);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Image = global::PlcFxUa.Properties.Resources.stop_32;
            this.btnStop.Location = new System.Drawing.Point(140, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(55, 55);
            this.btnStop.TabIndex = 11;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Image = global::PlcFxUa.Properties.Resources.pause_32;
            this.btnPause.Location = new System.Drawing.Point(75, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(55, 55);
            this.btnPause.TabIndex = 10;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(198)))));
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResume.Image = global::PlcFxUa.Properties.Resources.play_32;
            this.btnResume.Location = new System.Drawing.Point(10, 10);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(55, 55);
            this.btnResume.TabIndex = 9;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(362, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 75);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "label";
            // 
            // measurementBindingSource
            // 
            this.measurementBindingSource.DataSource = typeof(PlcFxUa.Measurement);
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lineChart);
            this.Controls.Add(this.treeServer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormData";
            this.Text = "FormData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormData_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeServer;
        private System.Windows.Forms.BindingSource measurementBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}