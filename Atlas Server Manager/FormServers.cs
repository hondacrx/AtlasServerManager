using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;
using System.Diagnostics;
using System.Management;
using StackExchange.Redis;
using System.ComponentModel;
using CoreRCON;

namespace AtlasServerManager
{
    public partial class FormServers : Form
    {
        List<ServerNodeControl> serverNodes = new();

        public FormServers()
        {
            InitializeComponent();
        }

        private void FormServers_Load(object sender, EventArgs e)
        {
            var servers = ServerGridParser.GetServers();
            if (servers == null || servers.Length == 0)
                return;

            foreach (var server in servers)
            {
                //todo load some of these from a file that keeps the info from last session

                var serverNode = new ServerNode();
                serverNode.Selected = true;
                serverNode.Active = true;
                serverNode.ServerName = server.name;
                serverNode.Grid = $"{(char)(server.gridX + 65)}{server.gridY + 1}";
                serverNode.SaveFolder = $"{(char)(server.gridX + 65)}{server.gridY + 1}";
                serverNode.Status = ServerStatus.Off;
                serverNodes.Add(new ServerNodeControl(serverNode));
            }

            flowLayoutPanel1.SuspendLayout();

            int selectedCount = 0;
            foreach (var server in serverNodes)
            {
                //Add server nodes to the layoutpanel
                flowLayoutPanel1.Controls.Add(server);

                if (server.IsSelected() && server.IsEnabled())
                    selectedCount++;
            }

            bStartSelectedGrids.Text = $"Start({selectedCount})";
            bStopSelectedGrids.Text = $"Start({selectedCount})";

            flowLayoutPanel1.ResumeLayout(false);
        }

        /// <summary>
        /// Handles all checking all the check boxes based on user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbSelect.SelectedItem)
            {
                case "All":
                    foreach (var server in serverNodes)
                        server.SetSelected(true);
                    break;
                case "None":
                    foreach (var server in serverNodes)
                        server.SetSelected(false);
                    break;
                case "Invert":
                    foreach (var server in serverNodes)
                        server.SetSelected(!server.IsSelected());
                    break;
                case "Enabled":
                    foreach (var server in serverNodes)
                        server.SetSelected(server.IsEnabled());
                    break;
                case "Running":
                    foreach (var server in serverNodes)
                        server.SetSelected(server.GetStatus() == ServerStatus.Running);
                    break;
                case "Off":
                    foreach (var server in serverNodes)
                        server.SetSelected(server.GetStatus() == ServerStatus.Off);
                    break;
            }

            int count = 0;
            foreach (var server in serverNodes)
            {
                if (server.IsSelected() && server.IsEnabled())
                    count ++;
            }

            bStartSelectedGrids.Text = $"Start({count})";
            bStopSelectedGrids.Text = $"Start({count})";
            flowLayoutPanel1.Refresh();
        }

        /// <summary>
        /// Starts selected grids.
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void bStartSelectedGrids_Click(object sender, EventArgs e)
        {
            foreach (var server in serverNodes)
            {
                if (!server.IsEnabled() || !server.IsSelected())
                    continue;

                StartServer(server);
            }
        }

        /// <summary>
        /// Sends stop rcon command to selected grids.
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void bStopSelectedGrids_Click(object sender, EventArgs e)
        {
            foreach (var server in serverNodes)
            {
                if (!server.IsEnabled() || !server.IsSelected())
                    continue;

                StopServer(server);
            }
        }

        /// <summary>
        /// Starts all grids.
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void bStartAllGrids_Click(object sender, EventArgs e)
        {
            foreach (var server in serverNodes)
            {
                if (!server.IsEnabled())
                    continue;

                StartServer(server);
            }
        }

        /// <summary>
        /// Sends stop rcon command to all grids.
        /// </summary>
        /// <param name="sender">Unused</param>
        /// <param name="e">Unused</param>
        private void bStopAllGrids_Click(object sender, EventArgs e)
        {
            foreach (var server in serverNodes)
            {
                if (!server.IsEnabled())
                    continue;

                StopServer(server);
            }
        }

        private void StartServer(ServerNodeControl server)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(server.Name, "");
            //process.Start();

            //set status
            server.SetStatus(ServerStatus.Starting);
            server.SetProcessId(process.Id);
        }

        private void StopServer(ServerNodeControl server)
        {
            //send rcon message

            //Wait for 30 secs? 
            //Timer every 5 secs to see if process is still active?  idk

            //once we get ok that server ended(ex check if rcon message is sent? or check if process id is still active?  if it is we need to altf4 it.
            //CheckAndKillProcess(server);

            //set status
            server.SetStatus(ServerStatus.Off);
        }

        /// <summary>
        /// Timer tick to check for any crashed servernodes.  if found lets restart them
        /// </summary>
        private void CheckForServerCrashs()
        {
            foreach (var server in serverNodes)
            {
                if (!server.IsEnabled())
                    continue;

                int processId = server.GetProcessId();
                var process = Process.GetProcessById(processId);
                if (process == null || process.HasExited)
                {
                    server.SetStatus(ServerStatus.Crashed);
                    StartServer(server);
                }
            }
        }

        private void CheckAndKillProcess(ServerNodeControl server)
        {
            int processId = server.GetProcessId();
            var process = Process.GetProcessById(processId);
            if (process != null && !process.HasExited)
            {
                MessageBox.Show($"Server: {server.GetServerName()} with ProcessId: {processId} failed to close, killing it.");
                Process.GetProcessById(processId).Kill(true);
            }
        }
    }
}
