
namespace PlcFxUa
{
    partial class FormPid
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tdLbl = new System.Windows.Forms.Label();
            this.xpLbl = new System.Windows.Forms.Label();
            this.tiLbl = new System.Windows.Forms.Label();
            this.kLbl = new System.Windows.Forms.Label();
            this.xpTB = new System.Windows.Forms.TextBox();
            this.tdTB = new System.Windows.Forms.TextBox();
            this.tiTB = new System.Windows.Forms.TextBox();
            this.kTB = new System.Windows.Forms.TextBox();
            this.minLbl = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.TextBox();
            this.maxLbl = new System.Windows.Forms.Label();
            this.maxTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputChart
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.inputChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.inputChart.Legends.Add(legend3);
            this.inputChart.Location = new System.Drawing.Point(429, 14);
            this.inputChart.Name = "inputChart";
            this.inputChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.inputChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Measurement";
            this.inputChart.Series.Add(series3);
            this.inputChart.Size = new System.Drawing.Size(943, 280);
            this.inputChart.TabIndex = 15;
            this.inputChart.Text = "inputChart";
            // 
            // outputChart
            // 
            chartArea4.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea4.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.BorderColor = System.Drawing.Color.Silver;
            chartArea4.Name = "ChartArea1";
            this.outputChart.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.outputChart.Legends.Add(legend4);
            this.outputChart.Location = new System.Drawing.Point(429, 308);
            this.outputChart.Name = "outputChart";
            this.outputChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.outputChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))))};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Measurement";
            this.outputChart.Series.Add(series4);
            this.outputChart.Size = new System.Drawing.Size(943, 280);
            this.outputChart.TabIndex = 16;
            this.outputChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.tdLbl);
            this.panel1.Controls.Add(this.xpLbl);
            this.panel1.Controls.Add(this.tiLbl);
            this.panel1.Controls.Add(this.kLbl);
            this.panel1.Controls.Add(this.xpTB);
            this.panel1.Controls.Add(this.tdTB);
            this.panel1.Controls.Add(this.tiTB);
            this.panel1.Controls.Add(this.kTB);
            this.panel1.Controls.Add(this.minLbl);
            this.panel1.Controls.Add(this.minTB);
            this.panel1.Controls.Add(this.maxLbl);
            this.panel1.Controls.Add(this.maxTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 600);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnResume);
            this.panel2.Location = new System.Drawing.Point(29, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 75);
            this.panel2.TabIndex = 42;
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
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(168, 339);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 41;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tdLbl
            // 
            this.tdLbl.AutoSize = true;
            this.tdLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tdLbl.Location = new System.Drawing.Point(28, 273);
            this.tdLbl.Name = "tdLbl";
            this.tdLbl.Size = new System.Drawing.Size(26, 21);
            this.tdLbl.TabIndex = 34;
            this.tdLbl.Text = "Td";
            // 
            // xpLbl
            // 
            this.xpLbl.AutoSize = true;
            this.xpLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xpLbl.Location = new System.Drawing.Point(212, 175);
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Size = new System.Drawing.Size(28, 21);
            this.xpLbl.TabIndex = 33;
            this.xpLbl.Text = "Xp";
            // 
            // tiLbl
            // 
            this.tiLbl.AutoSize = true;
            this.tiLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tiLbl.Location = new System.Drawing.Point(28, 220);
            this.tiLbl.Name = "tiLbl";
            this.tiLbl.Size = new System.Drawing.Size(22, 21);
            this.tiLbl.TabIndex = 32;
            this.tiLbl.Text = "Ti";
            // 
            // kLbl
            // 
            this.kLbl.AutoSize = true;
            this.kLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kLbl.Location = new System.Drawing.Point(28, 173);
            this.kLbl.Name = "kLbl";
            this.kLbl.Size = new System.Drawing.Size(19, 21);
            this.kLbl.TabIndex = 31;
            this.kLbl.Text = "K";
            // 
            // xpTB
            // 
            this.xpTB.Location = new System.Drawing.Point(264, 173);
            this.xpTB.Name = "xpTB";
            this.xpTB.Size = new System.Drawing.Size(100, 22);
            this.xpTB.TabIndex = 30;
            this.xpTB.Tag = "5";
            this.xpTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.xpTB_KeyDown);
            // 
            // tdTB
            // 
            this.tdTB.Location = new System.Drawing.Point(80, 272);
            this.tdTB.Name = "tdTB";
            this.tdTB.Size = new System.Drawing.Size(100, 22);
            this.tdTB.TabIndex = 29;
            this.tdTB.Tag = "4";
            this.tdTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdTB_KeyDown);
            // 
            // tiTB
            // 
            this.tiTB.Location = new System.Drawing.Point(80, 219);
            this.tiTB.Name = "tiTB";
            this.tiTB.Size = new System.Drawing.Size(100, 22);
            this.tiTB.TabIndex = 28;
            this.tiTB.Tag = "3";
            this.tiTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tiTB_KeyDown);
            // 
            // kTB
            // 
            this.kTB.Location = new System.Drawing.Point(80, 173);
            this.kTB.Name = "kTB";
            this.kTB.Size = new System.Drawing.Size(100, 22);
            this.kTB.TabIndex = 27;
            this.kTB.Tag = "2";
            this.kTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kTB_KeyDown);
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLbl.Location = new System.Drawing.Point(199, 90);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(41, 21);
            this.minLbl.TabIndex = 26;
            this.minLbl.Text = "MIN";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(80, 89);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(100, 22);
            this.minTB.TabIndex = 25;
            this.minTB.Tag = "1";
            this.minTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minTB_KeyDown);
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLbl.Location = new System.Drawing.Point(199, 43);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(44, 21);
            this.maxLbl.TabIndex = 24;
            this.maxLbl.Text = "MAX";
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(80, 42);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(100, 22);
            this.maxTB.TabIndex = 23;
            this.maxTB.Tag = "0";
            this.maxTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maxTB_KeyDown);
            // 
            // FormPid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1400, 600);
            this.Controls.Add(this.outputChart);
            this.Controls.Add(this.inputChart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPid";
            this.Text = "FormPid";
            this.Load += new System.EventHandler(this.FormPid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart inputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tdLbl;
        private System.Windows.Forms.Label xpLbl;
        private System.Windows.Forms.Label tiLbl;
        private System.Windows.Forms.Label kLbl;
        private System.Windows.Forms.TextBox xpTB;
        private System.Windows.Forms.TextBox tdTB;
        private System.Windows.Forms.TextBox tiTB;
        private System.Windows.Forms.TextBox kTB;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
    }
}