using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sda.TimeTracker.VSTS.Desktop
{
    public partial class fmConfig : Form
    {
        public fmConfig()
        {
            InitializeComponent();
        }

        private void fmConfig_Shown(object sender, EventArgs e)
        {
            textBoxTimeOfInativity.Text = Properties.Settings.Default.MinTimeOfInativity.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MinTimeOfInativity = int.Parse(textBoxTimeOfInativity.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
