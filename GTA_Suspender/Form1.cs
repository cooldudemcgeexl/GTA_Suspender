using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Suspender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gtaId = Get_GTAID();
            if (gtaId > 0)
            {
                Process gtaProcess = Process.GetProcessById(gtaId);
                Console.WriteLine(gtaProcess);
            }
            else
            {
                button1.Enabled = false;
                label1.Text = "GTA V Not Found. Are you sure \r\n you are running the game?";
                label1.ForeColor = Color.FromName("Red");
                Find_GTA_Retry();
            }
            //gtaProcess.Suspend();
            //await Task.Delay(5000);
            //gtaProcess.Resume();
        }
        private int Get_GTAID()
        {
            Process[] processList = Process.GetProcessesByName("GTA5");
            //Console.WriteLine(gtaProcess[0]);
            if (processList.Length == 0)
            {
                return 0;
            }
            int gtaID = processList[0].Id;
            //Console.WriteLine(gtaID);
            return gtaID;
        }

       private async void Find_GTA_Retry()
        {
            int gtaID = Get_GTAID();
            while (gtaID == 0)
            {
                await Task.Delay(500);
                gtaID = Get_GTAID();
            }
            label1.Text = "GTA V is currently running.";
            label1.ForeColor = Color.FromName("Black");
            button1.Enabled = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int suspendTime = (int)(numericUpDown1.Value * 1000);
            int gtaId = Get_GTAID();
            Process gtaProcess = Process.GetProcessById(gtaId);
            gtaProcess.Suspend();
            label1.Text = "GTA V suspended!";
            label1.ForeColor = Color.FromName("Green");
            await Task.Delay(suspendTime);
            gtaProcess.Resume();
            label1.Text = "GTA V is currently running.";
            label1.ForeColor = Color.FromName("Black");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
