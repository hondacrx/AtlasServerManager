using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;
using System.Diagnostics;
using System.Management;
using StackExchange.Redis;

namespace AtlasServerManager
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Start CrashDetector timer
            tCrashDetector.Start();
        }

        private void tPerformance_Tick(object sender, EventArgs e)
        {
        }

        private void tCrashDetector_Tick(object sender, EventArgs e)
        {
            /*foreach(var grid in gridServers)
            {
                var process = Process.GetProcessById(grid.GetProcessId());
                if (process == null || process.HasExited || process.ExitCode != 0)
                {
                    //restart process
                    Process newProcess = new();
                    newProcess.Start();
                    grid.SetProcessId(newProcess.Id);
                }
            }*/
        }
    }
}