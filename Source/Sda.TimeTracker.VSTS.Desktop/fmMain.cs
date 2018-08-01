
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using Sda.TimeTracker.VSTS.GettingStarted;
using Sda.TimeTracker.VSTS.ViewModel;
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
    public partial class fmMain : Form
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

        public fmMain()
        {
            InitializeComponent();
        }

        public VSTSContext VSTSContext = VSTSContext.Instance;

        private void fmMain_Load(object sender, EventArgs e)
        {
            //var fm = new fmLogin();
            //var result = fm.ShowDialog();

            //if (result == DialogResult.Cancel)
            //{
            //    this.Close();
            //} 

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, 0);
        }

        private void btnSelectQuery_Click(object sender, EventArgs e)
        {

            SelectWorkItem();

        }

        private void SelectWorkItem(WorkItemList workItemList = null)
        {

            if (CounterRunning)
            {
                MessageBox.Show("Stop The Work Tracking before select other WorkItem!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (workItemList == null)
            {
                var fm = new fmSelectQuery();
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    WorkItemSelected = fm.workItem;
                }
            }
            else
            {
                WorkItemSelected = workItemList;
            }

            if (WorkItemSelected == null)
                return;

            labelTaskValue.Text = WorkItemSelected.Id + " - " + WorkItemSelected.Title;
            labelEstimativeValue.Text = WorkItemSelected.OriginalEstimate.ToString();

            TimeSpan interval = DateTime.Now.Subtract(DateTime.Now);
            interval = interval.Add(TimeSpan.FromHours(WorkItemSelected.CompletedWork));

            labelStatus.Text = string.Format("{0:00}:{1:00}:{2:00}",
                (int)interval.TotalHours,
                interval.Minutes,
                interval.Seconds);

            buttonStartStop.Visible = true;
            buttonLink.Visible = true;

        }

        private WorkItemList WorkItemSelected;
        private DateTime StartTime;
        private double DiscoutsByInativity;
        private bool CounterRunning;

        private DateTime lastActivityDate;
        private double MinutesAllowedOfInativity;

        private DateTime LastActivityDate
        {
            get { return lastActivityDate; }
            set
            {
                lastActivityDate = value;
                //checkBoxInativity.Text = lastActivityDate.ToString();
            }
        }


        private void StartStop()
        {
            if (!CounterRunning)
            {
                if (WorkItemSelected == null)
                    MessageBox.Show("No WorkItem selected! Please Select a WorkItem.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    this.buttonStartStop.BackgroundImage = Sda.TimeTracker.VSTS.Desktop.Properties.Resources.Stop;
                    CounterRunning = true;
                    StartTime = DateTime.Now;
                    DiscoutsByInativity = 0;
                    this.timerElapsed.Start();


                    LastActivityDate = DateTime.Now;
                    MinutesAllowedOfInativity = 1;

                    UpdateWorkItem(true);

                }

            }
            else
            {
                this.buttonStartStop.BackgroundImage = Sda.TimeTracker.VSTS.Desktop.Properties.Resources.Play;
                CounterRunning = false;
                this.timerElapsed.Stop();

                var StopTime = DateTime.Now;

                TimeSpan interval = StopTime.Subtract(StartTime);

                double totalHours = interval.TotalHours - DiscoutsByInativity;

                //WorkItemSelected.CompletedWork += interval.TotalHours;
                //WorkItemSelected.RemainingWork -= interval.TotalHours;


                WorkItemSelected.CompletedWork = Math.Round(WorkItemSelected.CompletedWork + totalHours, 2);
                WorkItemSelected.RemainingWork = Math.Round(WorkItemSelected.RemainingWork - totalHours, 2);

                if (WorkItemSelected.RemainingWork < 0) WorkItemSelected.RemainingWork = 0d;

                UpdateWorkItem(false);

                SelectWorkItem(WorkItemSelected);

            }

            this.buttonClose.Visible = !CounterRunning;

        }

        public void UpdateWorkItem(Boolean isStarting)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var _id = WorkItemSelected.Id;

                JsonPatchDocument patchDocument = new JsonPatchDocument();

                if (isStarting)
                {
                    patchDocument.Add(
                        new JsonPatchOperation()
                        {
                            Operation = Operation.Add,
                            Path = "/fields/System.History",
                            Value = "Tracking work time on VSTS.TimeTracking"
                        }
                    );

                    patchDocument.Add(
                        new JsonPatchOperation()
                        {
                            Operation = Operation.Add,
                            Path = "/fields/System.State",
                            Value = "Active"
                        }
                    );
                }
                else
                {
                    patchDocument.Add(
                        new JsonPatchOperation()
                        {
                            Operation = Operation.Add,
                            Path = "/fields/System.State",
                            Value = "New"
                        }
                    );
                }

                patchDocument.Add(
                    new JsonPatchOperation()
                    {
                        Operation = Operation.Add,
                        Path = "/fields/Microsoft.VSTS.Scheduling.RemainingWork",
                        Value = WorkItemSelected.RemainingWork
                    }
                );

                patchDocument.Add(
                    new JsonPatchOperation()
                    {
                        Operation = Operation.Add,
                        Path = "/fields/Microsoft.VSTS.Scheduling.CompletedWork",
                        Value = WorkItemSelected.CompletedWork
                    }
                );

                VssConnection connection = new VssConnection(new Uri(VSTSContext.Instance.UriString),
                                                             new VssBasicCredential(VSTSContext.Instance.UserName, VSTSContext.Instance.Password));

                WorkItemTrackingHttpClient workItemTrackingHttpClient = connection.GetClient<WorkItemTrackingHttpClient>();
                WorkItem result = workItemTrackingHttpClient.UpdateWorkItemAsync(patchDocument, _id).Result;

                patchDocument = null;

                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message + ex.InnerException == null ? " | " + ex.InnerException.Message : "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timerElapsed_Tick(object sender, EventArgs e)
        {

            if (CounterRunning)
            {

                //TimeSpan EstimativeTimespan = TimeSpan.FromHours(workingItem.Estimates.Duration);
                //textBoxTaskDurationValue.Text = string.Format("{0:00}:{1:00}",
                //    (int)EstimativeTimespan.TotalHours,
                //    EstimativeTimespan.Minutes);

                TimeSpan interval = DateTime.Now.Subtract(StartTime);
                interval = interval.Add(TimeSpan.FromHours(WorkItemSelected.CompletedWork));

                labelStatus.Text = string.Format("{0:00}:{1:00}:{2:00}",
                    (int)interval.TotalHours,
                    interval.Minutes,
                    interval.Seconds);

                //Verifica Inatividade
                if (checkBoxInativity.Checked)
                {

                    var intervalInativity = DateTime.Now.Subtract(LastActivityDate);

                    if (intervalInativity.TotalMinutes > MinutesAllowedOfInativity)
                    {
                        panelInativity.BackColor = Color.Red;
                    }
                    else
                    {
                        panelInativity.BackColor = Color.AliceBlue;
                    }

                    checkBoxInativity.Text = intervalInativity.TotalSeconds.ToString();
                }
            }
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            panelDescription.Visible = !panelDescription.Visible;
            if (panelDescription.Visible)
            {
                this.Size = new Size(676, 48);
            }
            else
            {
                this.Size = new Size(266, 48);
            }

        }

        private void labelTaskValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectWorkItem();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectWorkItem();
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(VSTSContext.Instance.UriString + "/web/wi.aspx?&fullScreen=true&id=" + WorkItemSelected.Id);
        }

        private void fmMain_Shown(object sender, EventArgs e)
        {
            var fm = new fmLogin();
            var result = fm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                this.Close();
            }

            GetConfigurations();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CounterRunning)
            {
                var result = MessageBox.Show("Would you like to save the work tracked to this WorkItem?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    StartStop();
                if (result == DialogResult.Cancel)
                    e.Cancel = true;

            }
        }

        private void globalEventProvider1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        //private int Inativity = 0;


        private void buttonConfig_Click(object sender, EventArgs e)
        {
            if (CounterRunning)
            {
                MessageBox.Show("Stop The Work Tracking before select other WorkItem!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fm = new fmConfig();
            fm.ShowDialog();

            GetConfigurations();
        }

        public void GetConfigurations()
        {
            MinutesAllowedOfInativity = Properties.Settings.Default.MinTimeOfInativity;
        }

        private void globalEventProvider1_KeyDown(object sender, KeyEventArgs e)
        {
            RefreshMonitorOfInativity();
        }

        private void globalEventProvider1_MouseMoveExt(object sender, Gma.UserActivityMonitor.MouseEventExtArgs e)
        {
            RefreshMonitorOfInativity();
        }

        private void RefreshMonitorOfInativity()
        {
            if (CounterRunning && checkBoxInativity.Checked)
            {
                var interval = DateTime.Now.Subtract(LastActivityDate);

                if (interval.TotalMinutes > MinutesAllowedOfInativity)
                {
                    LastActivityDate = DateTime.Now;
                    panelInativity.BackColor = Color.AliceBlue;
                    var result = MessageBox.Show("You've been away for a long time. Do you like to substract this time (" + Math.Round(interval.TotalMinutes, 2).ToString() + " Minutes) from Actual Work tracking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DiscoutsByInativity += interval.TotalHours;
                    }

                }
                else
                {
                    if (interval.TotalSeconds > 30)
                        LastActivityDate = DateTime.Now;

                }

            }

            //checkBoxInativity.Text = string.Format("x={0:0000}; y={1:0000}", e.X, e.Y);

        }
    }
}
