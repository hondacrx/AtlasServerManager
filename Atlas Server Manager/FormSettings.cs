using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AtlasServerManager
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./AtlasServerManagerConfig.json", JsonConvert.SerializeObject(FormMain.Settings, Formatting.Indented));
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
