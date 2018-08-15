using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sda.TimeTracker.VSTS.Desktop
{
    public partial class fmTest : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        //private const int HTCLIENT = 0x1;
        public const int HT_CAPTION = 0x2;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void fmMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public fmTest()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

        private void fmTest_Shown(object sender, EventArgs e)
        {
            //var fm = new fmLogin();
            //var result = fm.ShowDialog();

            //if (result == DialogResult.Cancel)
            //{
            //    this.Close();
            //}
        }
    }
}
