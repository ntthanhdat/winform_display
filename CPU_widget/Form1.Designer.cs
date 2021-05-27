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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RamPercent = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CpuPercent = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.performanceRAM = new System.Diagnostics.PerformanceCounter();
            this.performanceCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.metroButton1);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel3);
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
            // CpuPercent
            // 
            this.CpuPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpuPercent.AutoSize = true;
            this.CpuPercent.Location = new System.Drawing.Point(139, 14);
            this.CpuPercent.Name = "CpuPercent";
            this.CpuPercent.Size = new System.Drawing.Size(20, 19);
            this.CpuPercent.TabIndex = 5;
            this.CpuPercent.Text = "%";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroProgressBarCPU.Location = new System.Drawing.Point(19, 49);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(215, 26);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(253, 194);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "CPU";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroButton1.Location = new System.Drawing.Point(404, 14);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.metroContextMenu1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(503, 316);
            this.listBox1.TabIndex = 10;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(134, 26);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.killToolStripMenuItem.Text = "Kill process";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killclick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Processing:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows Ctrl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).EndInit();
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
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
    }
}

