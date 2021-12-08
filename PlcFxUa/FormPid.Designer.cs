
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.runBtn = new System.Windows.Forms.RadioButton();
            this.helpLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // inputChart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.inputChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.inputChart.Legends.Add(legend1);
            this.inputChart.Location = new System.Drawing.Point(429, 14);
            this.inputChart.Name = "inputChart";
            this.inputChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.inputChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(132)))), ((int)(((byte)(52)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Measure";
            this.inputChart.Series.Add(series1);
            this.inputChart.Size = new System.Drawing.Size(943, 280);
            this.inputChart.TabIndex = 15;
            this.inputChart.Text = "inputChart";
            // 
            // outputChart
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.outputChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.outputChart.Legends.Add(legend2);
            this.outputChart.Location = new System.Drawing.Point(429, 308);
            this.outputChart.Name = "outputChart";
            this.outputChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.outputChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(93)))), ((int)(((byte)(99)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Measure";
            this.outputChart.Series.Add(series2);
            this.outputChart.Size = new System.Drawing.Size(943, 280);
            this.outputChart.TabIndex = 16;
            this.outputChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.runBtn);
            this.panel1.Controls.Add(this.helpLabel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnResume);
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
            // runBtn
            // 
            this.runBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.runBtn.AutoSize = true;
            this.runBtn.Location = new System.Drawing.Point(162, 344);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(44, 27);
            this.runBtn.TabIndex = 39;
            this.runBtn.TabStop = true;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.CheckedChanged += new System.EventHandler(this.runBtn_CheckedChanged);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(59, 393);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(46, 17);
            this.helpLabel.TabIndex = 38;
            this.helpLabel.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save to CSV";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(150, 520);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 36;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(44, 520);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 35;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart inputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton runBtn;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
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
    }
}