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
    public partial class MainForm : Form
    {
        public const string GTARunning = "GTA V is currently running. \r\n Ready to suspend.";
        public const string GTALost = "GTA V not found. Are you sure \r\n the game is running?";
        public const string suspendMsg = "GTA V suspended!";
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Defaults to checking for case that GTA is running.
            Find_GTA_Running();          
        }


        /// <summary>
        /// Returns the current process ID of GTA 5, 0 if GTA 5 is not found.
        /// </summary>
        /// <returns>GTA 5 process ID as int.</returns>
        private int Get_GTAID()
        {
            Process[] processList = Process.GetProcessesByName("GTA5");
            if (processList.Length == 0)
            {
                // GTA process will never be 0. 0 will be used to represent the GTA process not existing.
                return 0;
            }
            int gtaID = processList[0].Id;
            return gtaID;
        }

        /// <summary>
        /// Attempts to find GTA 5 in case that GTA process is running.
        /// </summary>
        private async void Find_GTA_Running()
        {
            int gtaID = Get_GTAID();
            while(gtaID != 0)
            {
                // Polls every 500 ms for GTA process ID.
                await Task.Delay(500);
                gtaID = Get_GTAID();
            }

            // Button to suspend will be disabled if GTA is not found to prevent user from suspending an incorrect process.

            StatusMsg.Text = GTALost;
            StatusMsg.ForeColor = Color.FromName("Red");
            SuspendButton.Enabled = false;
            Find_GTA_Retry();
        }

        /// <summary>
        /// Attempts to find GTA 5 in case that GTA process has ended.
        /// </summary>
        private async void Find_GTA_Retry()
        {
            int gtaID = Get_GTAID();
            while (gtaID == 0)
            {
                // Polls every 500 ms for GTA process ID.
                await Task.Delay(500);
                gtaID = Get_GTAID();
            }
            StatusMsg.Text = GTARunning;
            StatusMsg.ForeColor = Color.FromName("Black");
            SuspendButton.Enabled = true;
            Find_GTA_Running();
        }


        private async void SuspendButton_Click(object sender, EventArgs e)
        {
            // Gets suspension duration from up/down box. Default is 10s based on my own personal testing.
            int suspendTime = (int)(SuspendTimeUD.Value * 1000);
            
            // Gets GTA process and then suspends.
            int gtaID = Get_GTAID();
            Process gtaProcess = Process.GetProcessById(gtaID);
            gtaProcess.Suspend();

            StatusMsg.Text = suspendMsg;
            StatusMsg.ForeColor = Color.FromName("Green");

            // Waits for specified suspension time to resume GTA 5.
            await Task.Delay(suspendTime);
            gtaProcess.Resume();


            // Checks gtaID again to set program to proper state (GTA found/not found).
            gtaID = Get_GTAID();
            if (gtaID != 0) { 
                StatusMsg.Text = GTARunning;
                StatusMsg.ForeColor = Color.FromName("Black");
                SuspendButton.Enabled = true;
                Find_GTA_Running();
            }
            else
            {
                StatusMsg.Text = GTALost;
                StatusMsg.ForeColor = Color.FromName("Red");
                SuspendButton.Enabled = false;
                Find_GTA_Retry();
            }
        }

    }

}
