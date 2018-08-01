using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Sda.TimeTracker.VSTS.GettingStarted;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sda.TimeTracker.VSTS.Desktop
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;

            VSTSContext.Instance.AccountName = txtVSTSAccount.Text;
            VSTSContext.Instance.UserName = txtUsername.Text;
            VSTSContext.Instance.Password = txtPassword.Text;
            //VSTSContext.Instance.PersonalAccessToken = "oeb3d5si6jsmxe3ybqlyak62by7cnqpn2wu2g3z7odglsx4iaerq";

            try
            {
                Cursor = Cursors.WaitCursor;


                var result = Authenticate();

                if (result == "Success")
                {
                
                        SaveUserConfigurations();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                        Cursor = Cursors.Default;

              
                } else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Invalid Credentials!!! Error: " + result,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }


        }

        public void SaveUserConfigurations()
        {
            if (checkBoxRememberMe.Checked)
            {
                Properties.Settings.Default.VSTSAccount = txtVSTSAccount.Text;
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.PersonalToken = txtPassword.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string Authenticate(string project = "Sda.Afs")
        {
            //string project = VSTSContext.Instance.Project;

            // create a query to get your list of work items needed
            Wiql wiql = new Wiql()
            {
                Query = "Select [State], [Title] " +
                        "From WorkItems " +
                        "Where [Work Item Type] = 'Bug' " +
                        "And [System.TeamProject] = '" + project + "' " +
                        "And [System.State] = 'New' " +
                        "Order By [State] Asc, [Changed Date] Desc"
            };

            //VssConnection connection = new VssConnection(new Uri(VSTSContext.Instance.UriString), 
            //                                             new VssBasicCredential(VSTSContext.Instance.UserName,
            //                                                                    VSTSContext.Instance.Password));

            VssConnection connection = new VssConnection(new Uri(VSTSContext.Instance.UriString),
                                                         new VssBasicCredential(VSTSContext.Instance.UserName, VSTSContext.Instance.Password));
            

            WorkItemTrackingHttpClient workItemTrackingHttpClient = connection.GetClient<WorkItemTrackingHttpClient>();

            WorkItemQueryResult workItemQueryResult;

            try
            {
                // execute the query
                workItemQueryResult = workItemTrackingHttpClient.QueryByWiqlAsync(wiql).Result;

            }
            catch (Exception e) { return e.Message; }

            return "Success";
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            labelVersionValue.Text = Properties.Settings.Default.Version;
            if (Properties.Settings.Default.RememberMe)
            {
                txtVSTSAccount.Text = Properties.Settings.Default.VSTSAccount;
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.PersonalToken;
                checkBoxRememberMe.Checked = true;
            }
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            var strAccount = string.IsNullOrEmpty(txtVSTSAccount.Text) ? "" : txtVSTSAccount.Text + ".";
            System.Diagnostics.Process.Start("https://"+ strAccount + "visualstudio.com/_details/security/tokens");
        }
    }
}
