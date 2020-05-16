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
            int gtaID = Get_GTAID();
            Console.WriteLine(gtaID);
        }
        private int Get_GTAID()
        {
            Process[] gtaProcess = Process.GetProcessesByName("GTA5");
            //Console.WriteLine(gtaProcess[0]);
            int gtaID = gtaProcess[0].Id;
            //Console.WriteLine(gtaID);
            return gtaID;
        }

        private void Suspend_Game(int processID)
        {
            N
        }
    }

}
