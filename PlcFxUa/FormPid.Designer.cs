
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.TextBox();
            this.tiTB = new System.Windows.Forms.TextBox();
            this.kTB = new System.Windows.Forms.TextBox();
            this.xpTB = new System.Windows.Forms.TextBox();
            this.tdTB = new System.Windows.Forms.TextBox();
            this.tiLbl = new System.Windows.Forms.Label();
            this.kLbl = new System.Windows.Forms.Label();
            this.tdLbl = new System.Windows.Forms.Label();
            this.xpLbl = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.inputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChart)).BeginInit();
            this.SuspendLayout();
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(103, 42);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(100, 22);
            this.maxTB.TabIndex = 0;
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(238, 45);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(37, 17);
            this.maxLbl.TabIndex = 1;
            this.maxLbl.Text = "MAX";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(238, 92);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(32, 17);
            this.minLbl.TabIndex = 3;
            this.minLbl.Text = "MIN";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(103, 89);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(100, 22);
            this.minTB.TabIndex = 2;
            // 
            // tiTB
            // 
            this.tiTB.Location = new System.Drawing.Point(103, 219);
            this.tiTB.Name = "tiTB";
            this.tiTB.Size = new System.Drawing.Size(100, 22);
            this.tiTB.TabIndex = 5;
            // 
            // kTB
            // 
            this.kTB.Location = new System.Drawing.Point(103, 172);
            this.kTB.Name = "kTB";
            this.kTB.Size = new System.Drawing.Size(100, 22);
            this.kTB.TabIndex = 4;
            // 
            // xpTB
            // 
            this.xpTB.Location = new System.Drawing.Point(314, 170);
            this.xpTB.Name = "xpTB";
            this.xpTB.Size = new System.Drawing.Size(100, 22);
            this.xpTB.TabIndex = 7;
            // 
            // tdTB
            // 
            this.tdTB.Location = new System.Drawing.Point(103, 272);
            this.tdTB.Name = "tdTB";
            this.tdTB.Size = new System.Drawing.Size(100, 22);
            this.tdTB.TabIndex = 6;
            // 
            // tiLbl
            // 
            this.tiLbl.AutoSize = true;
            this.tiLbl.Location = new System.Drawing.Point(29, 222);
            this.tiLbl.Name = "tiLbl";
            this.tiLbl.Size = new System.Drawing.Size(20, 17);
            this.tiLbl.TabIndex = 9;
            this.tiLbl.Text = "Ti";
            // 
            // kLbl
            // 
            this.kLbl.AutoSize = true;
            this.kLbl.Location = new System.Drawing.Point(29, 175);
            this.kLbl.Name = "kLbl";
            this.kLbl.Size = new System.Drawing.Size(17, 17);
            this.kLbl.TabIndex = 8;
            this.kLbl.Text = "K";
            // 
            // tdLbl
            // 
            this.tdLbl.AutoSize = true;
            this.tdLbl.Location = new System.Drawing.Point(29, 275);
            this.tdLbl.Name = "tdLbl";
            this.tdLbl.Size = new System.Drawing.Size(25, 17);
            this.tdLbl.TabIndex = 11;
            this.tdLbl.Text = "Td";
            // 
            // xpLbl
            // 
            this.xpLbl.AutoSize = true;
            this.xpLbl.Location = new System.Drawing.Point(238, 175);
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Size = new System.Drawing.Size(25, 17);
            this.xpLbl.TabIndex = 10;
            this.xpLbl.Text = "Xp";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(188, 337);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 14;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // inputChart
            // 
            this.inputChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea7.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea7.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea7.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.BorderColor = System.Drawing.Color.Silver;
            chartArea7.Name = "ChartArea1";
            this.inputChart.ChartAreas.Add(chartArea7);
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Name = "Legend1";
            this.inputChart.Legends.Add(legend7);
            this.inputChart.Location = new System.Drawing.Point(453, 12);
            this.inputChart.Name = "inputChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Measure";
            this.inputChart.Series.Add(series7);
            this.inputChart.Size = new System.Drawing.Size(626, 227);
            this.inputChart.TabIndex = 15;
            this.inputChart.Text = "inputChart";
            // 
            // outputChart
            // 
            this.outputChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea8.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea8.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea8.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea8.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.BorderColor = System.Drawing.Color.Silver;
            chartArea8.Name = "ChartArea1";
            this.outputChart.ChartAreas.Add(chartArea8);
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Name = "Legend1";
            this.outputChart.Legends.Add(legend8);
            this.outputChart.Location = new System.Drawing.Point(453, 245);
            this.outputChart.Name = "outputChart";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Measure";
            this.outputChart.Series.Add(series8);
            this.outputChart.Size = new System.Drawing.Size(626, 233);
            this.outputChart.TabIndex = 16;
            this.outputChart.Text = "chart1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1097, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 54);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save to CSV";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(1108, 115);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(1108, 61);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 17;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // FormPid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 480);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.outputChart);
            this.Controls.Add(this.inputChart);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.tdLbl);
            this.Controls.Add(this.xpLbl);
            this.Controls.Add(this.tiLbl);
            this.Controls.Add(this.kLbl);
            this.Controls.Add(this.xpTB);
            this.Controls.Add(this.tdTB);
            this.Controls.Add(this.tiTB);
            this.Controls.Add(this.kTB);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.maxTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPid";
            this.Text = "FormPid";
            this.Load += new System.EventHandler(this.FormPid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.TextBox tiTB;
        private System.Windows.Forms.TextBox kTB;
        private System.Windows.Forms.TextBox xpTB;
        private System.Windows.Forms.TextBox tdTB;
        private System.Windows.Forms.Label tiLbl;
        private System.Windows.Forms.Label kLbl;
        private System.Windows.Forms.Label tdLbl;
        private System.Windows.Forms.Label xpLbl;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart inputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart outputChart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
    }
}