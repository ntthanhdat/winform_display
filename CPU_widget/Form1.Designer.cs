namespace CPU_widget
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CpuPercent = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.performanceRAM = new System.Diagnostics.PerformanceCounter();
            this.performanceCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RamPercent = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(760, 370);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RamPercent);
            this.splitContainer2.Panel1.Controls.Add(this.metroProgressBarRAM);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer2.Panel1.Controls.Add(this.CpuPercent);
            this.splitContainer2.Panel1.Controls.Add(this.metroProgressBarCPU);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart1);
            this.splitContainer2.Size = new System.Drawing.Size(253, 370);
            this.splitContainer2.SplitterDistance = 172;
            this.splitContainer2.TabIndex = 0;
            // 
            // CpuPercent
            // 
            this.CpuPercent.AutoSize = true;
            this.CpuPercent.Location = new System.Drawing.Point(139, 14);
            this.CpuPercent.Name = "CpuPercent";
            this.CpuPercent.Size = new System.Drawing.Size(20, 19);
            this.CpuPercent.TabIndex = 5;
            this.CpuPercent.Text = "%";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(19, 49);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(215, 26);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU:";
            // 
            // performanceRAM
            // 
            this.performanceRAM.CategoryName = "Memory";
            this.performanceRAM.CounterName = "% Committed Bytes In Use";
            // 
            // performanceCPU
            // 
            this.performanceCPU.CategoryName = "Processor";
            this.performanceCPU.CounterName = "% Processor Time";
            this.performanceCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(3, 5);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "CPU";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "RAM";
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Size = new System.Drawing.Size(247, 186);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "CPU";
            // 
            // RamPercent
            // 
            this.RamPercent.AutoSize = true;
            this.RamPercent.Location = new System.Drawing.Point(139, 91);
            this.RamPercent.Name = "RamPercent";
            this.RamPercent.Size = new System.Drawing.Size(20, 19);
            this.RamPercent.TabIndex = 8;
            this.RamPercent.Text = "%";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(19, 124);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(215, 25);
            this.metroProgressBarRAM.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "RAM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "CPU monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Diagnostics.PerformanceCounter performanceRAM;
        private System.Diagnostics.PerformanceCounter performanceCPU;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CpuPercent;
        private MetroFramework.Controls.MetroLabel RamPercent;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

