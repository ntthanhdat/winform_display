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
            chart1.Series["CPU"].Points.AddY(fCpu);
            chart1.Series["RAM"].Points.AddY(fRam);
            
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void UpdateProcesses()
        {
            ListBox lb2 = new ListBox();
            listBox1.Items.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                lb2.Items.Add(p.ProcessName + "  -  " + p.Id);
            }

            ArrayList q = new ArrayList();
            foreach (object o in lb2.Items)
                q.Add(o);
            q.Sort();
            foreach (object o in q)
            {
                listBox1.Items.Add(o);
            }

        }
        public void KillProcess()
        {
            foreach (Process p in Process.GetProcesses())
            {
                string[] arr = listBox1.SelectedItem.ToString().Split('-');
                string process = arr[0].Trim();
                int id = Convert.ToInt32(arr[1].Trim());
                if(p.ProcessName == process && p.Id == id)
                {
                    try
                    {
                        p.Kill();
                        MessageBox.Show("Process killed", "Task manager");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Failed to kill process", "Task manager");
                    }
                }
            }
            UpdateProcesses();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            UpdateProcesses();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            UpdateProcesses();
        }

       


        private void killclick(object sender, EventArgs e)
        {
            KillProcess();
        }
    }
}
