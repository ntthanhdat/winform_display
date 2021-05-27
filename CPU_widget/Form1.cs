using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace CPU_widget
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            float fCpu = performanceCPU.NextValue();
            float fRam = performanceRAM.NextValue();
            metroProgressBarCPU.Value = (int)fCpu;
            metroProgressBarRAM.Value = (int)fRam;
            CpuPercent.Text = string.Format("{0:0.00}%", fCpu);
            RamPercent.Text = string.Format("{0:0.00}%", fRam);
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }

    }
}
