using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtlasServerManager
{
    public partial class ServerNodeControl : UserControl
    {
        public ServerNodeControl()
        {
            InitializeComponent();
        }

        public ServerNodeControl(ServerNode serverNode)
        {
            InitializeComponent();

            cbSelect.Checked = serverNode.Selected;
            bEnabled.Checked = serverNode.Active;

            listBox1.Items.Add(serverNode.ServerName);
            listBox1.Items.Add(serverNode.Grid);
            listBox1.Items.Add(serverNode.Players);
            listBox1.Items.Add(serverNode.CpuPercent);
            listBox1.Items.Add(serverNode.MemoryMB);
            listBox1.Items.Add(serverNode.SaveFolder);
            listBox1.Items.Add(serverNode.ProcessId);
            listBox1.Items.Add(serverNode.Status);
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string output = listBox1.Items[e.Index].ToString();
            float olength = e.Graphics.MeasureString(output, e.Font).Width;
            float center = listBox1.ColumnWidth * (e.Index + 1) - listBox1.ColumnWidth / 2;
            float pos = center - olength / 2;
            SolidBrush brush = new SolidBrush(e.ForeColor);

            //Change status color
            if (e.Index == 7)
            {
                switch ((ServerStatus)listBox1.Items[e.Index])
                {
                    case ServerStatus.Starting:
                        brush.Color = Color.Blue;
                        break;
                    case ServerStatus.Running:
                        brush.Color = Color.Green;
                        break;
                    case ServerStatus.Crashed:
                        brush.Color = Color.Red;
                        break;
                    case ServerStatus.Closing:
                        brush.Color = Color.Yellow;
                        break;
                }
            }

            //if (e.Index == 0)
                //e.Graphics.DrawString("|", e.Font, brush, 0, e.Bounds.Top);
            e.Graphics.DrawString(output, e.Font, brush, pos, e.Bounds.Top);
            //e.Graphics.DrawString("|", e.Font, brush, listBox1.ColumnWidth * (e.Index + 1), e.Bounds.Top);
        }

        public bool IsSelected()
        {
            return cbSelect.Checked;
        }

        public void SetSelected(bool value)
        {
            cbSelect.Checked = value;
        }

        public bool IsEnabled()
        {
            return bEnabled.Checked;
        }

        public void SetActive(bool value)
        {
            bEnabled.Checked = value;
        }

        public string GetServerName()
        {
            return (string)listBox1.Items[0];
        }

        public void SetPlayerCount(string playerCount)
        {
            listBox1.Items[2] = playerCount;
        }

        public void SetCpuPercent(int cpuPercent)
        {
            listBox1.Items[3] = $"{cpuPercent}%";
        }

        public void SetMemoryMB(int memoryMB)
        {
            listBox1.Items[4] = memoryMB;
        }

        public string GetSaveFolder()
        {
            return (string)listBox1.Items[5];
        }

        public int GetProcessId()
        {
            return (int)listBox1.Items[6];
        }

        public void SetProcessId(int processId)
        {
            listBox1.Items[6] = processId;
        }

        public ServerStatus GetStatus()
        {
            return (ServerStatus)listBox1.Items[7];
        }

        public void SetStatus(ServerStatus serverStatus)
        {
            listBox1.Items[7] = serverStatus;
        }

        private void bEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!bEnabled.Checked)
                cbSelect.Checked = false;
        }
    }

    public class ServerNode
    {
        public bool Selected { get; set; }
        public bool Active { get; set; }
        public string ServerName { get; set; } = "-";
        public string Grid { get; set; } = "-";
        public string Players { get; set; } = "0/0";
        public string CpuPercent { get; set; } = "-";
        public string MemoryMB { get; set; } = "-";
        public string SaveFolder { get; set; } = "-";
        public int ProcessId { get; set; }
        public ServerStatus Status { get; set; }
    }

    public enum ServerStatus
    {
        Off,
        Starting,
        Running,
        Crashed,
        Closing
    }
}
