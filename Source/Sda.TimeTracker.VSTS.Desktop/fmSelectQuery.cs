using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Sda.TimeTracker.VSTS.ViewModel;
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
    public partial class fmSelectQuery : Form
    {
        public fmSelectQuery()
        {
            InitializeComponent();
        }

        private void fmSelectQuery_Load(object sender, EventArgs e)
        {



        }


        public List<WorkItemList> QueryWorkItems_Wiql()
        {
            //string project = _configuration.Project;

            string WiqlSelect = "Select [State], [Title], [System.TeamProject], [Microsoft.VSTS.Common.Priority], [Microsoft.VSTS.Scheduling.OriginalEstimate], [Microsoft.VSTS.Scheduling.RemainingWork],[Microsoft.VSTS.Scheduling.CompletedWork] " +
                                "From WorkItems ";

            string WiqlWhere = "Where [System.AssignedTo] = @Me And [Work Item Type] = 'Task' ";

            if (checkBoxShowBugs.Checked)
            {
                WiqlWhere = "Where [System.AssignedTo] = @Me And ([Work Item Type] = 'Task' OR [Work Item Type] = 'Bug') ";
            }

            if (!string.IsNullOrEmpty(textBoxCode.Text))
                WiqlWhere += " And [System.Id] = '" + textBoxCode.Text + "' ";

            WiqlWhere += " And ([System.State] = 'Active' OR [System.State] = 'New' ) ";

            string WiqlOrderBy = " Order By [System.TeamProject] Asc, [Microsoft.VSTS.Common.Priority] Asc, [State] Asc, [Changed Date] Desc";


            // create a query to get your list of work items needed
            Wiql wiql = new Wiql()
            {
                Query = WiqlSelect + WiqlWhere + WiqlOrderBy
            };


            //VssConnection connection = new VssConnection(_uri, _credentials);
            VssConnection connection = new VssConnection(new Uri(VSTSContext.Instance.UriString),
                                                         new VssBasicCredential(VSTSContext.Instance.UserName, VSTSContext.Instance.Password));


            WorkItemTrackingHttpClient workItemTrackingHttpClient = connection.GetClient<WorkItemTrackingHttpClient>();

            // execute the query
            WorkItemQueryResult workItemQueryResult = workItemTrackingHttpClient.QueryByWiqlAsync(wiql).Result;

            // check to make sure we have some results
            if (workItemQueryResult == null || workItemQueryResult.WorkItems.Count() == 0)
            {
                //return "Wiql '" + wiql.Query + "' did not find any results";
                return new List<WorkItemList>();
            }
            else
            {
                // need to get the list of our work item id's and put them into an array
                List<int> list = new List<int>();
                foreach (var item in workItemQueryResult.WorkItems)
                {
                    list.Add(item.Id);
                }
                int[] arr = list.ToArray();

                // build a list of the fields we want to see
                string[] fields = new string[8];
                fields[0] = "System.Id";
                fields[1] = "System.Title";
                fields[2] = "System.State";
                fields[3] = "System.TeamProject";
                fields[4] = "Microsoft.VSTS.Common.Priority";
                fields[5] = "Microsoft.VSTS.Scheduling.OriginalEstimate";
                fields[6] = "Microsoft.VSTS.Scheduling.RemainingWork";
                fields[7] = "Microsoft.VSTS.Scheduling.CompletedWork";


                var workItems = workItemTrackingHttpClient.GetWorkItemsAsync(arr, fields, workItemQueryResult.AsOf).Result;
                

                var wiList = workItems.Select(p => new WorkItemList {
                                                                    WorkItem = p,
                                                                    Id = int.Parse(p.Fields.GetValueOrDefault("System.Id", 0).ToString()),
                                                                    State = p.Fields.GetValueOrDefault("System.State", "").ToString(),
                                                                    TeamProject = p.Fields.GetValueOrDefault("System.TeamProject", "").ToString(),
                                                                    Priority = p.Fields.GetValueOrDefault("Microsoft.VSTS.Common.Priority", "").ToString(),
                                                                    Title = p.Fields.GetValueOrDefault("System.Title", "").ToString(),
                                                                    OriginalEstimate = double.Parse(p.Fields.GetValueOrDefault("Microsoft.VSTS.Scheduling.OriginalEstimate", "0").ToString()),
                                                                    RemainingWork = double.Parse(p.Fields.GetValueOrDefault("Microsoft.VSTS.Scheduling.RemainingWork", "0").ToString()),
                                                                    CompletedWork = double.Parse(p.Fields.GetValueOrDefault("Microsoft.VSTS.Scheduling.CompletedWork", "0").ToString()),
                } ).ToList();



                return wiList;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public WorkItemList workItem;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectWorkItem();
        }

        private void SelectWorkItem()
        {

            if (this.dataGridView1.CurrentRow != null)
            {
                this.DialogResult = DialogResult.OK;
                this.workItem = this.dataGridView1.CurrentRow.DataBoundItem as WorkItemList;
            }
            else
            {
                MessageBox.Show("Select a WorkItem!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            SelectWorkItem();
        }

        private void checkBoxShowBugs_CheckedChanged(object sender, EventArgs e)
        {
            SearchWorkItems();
        }

        private void fmSelectQuery_Shown(object sender, EventArgs e)
        {
            SearchWorkItems();
        }


        public void SearchWorkItems()
        {
            List<WorkItemList> resultQuery = new List<WorkItemList>();

            try
            {
                Cursor = Cursors.WaitCursor;
                resultQuery = QueryWorkItems_Wiql();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.InnerException != null ? ex.Message + " | " + ex.InnerException.Message : ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (resultQuery == null)
            {
                MessageBox.Show("WorkItems not found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultQuery;
            }
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            SearchWorkItems();
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;

            if(e.KeyChar == (char)Keys.Enter)
            {                
                e.Handled = true;
                SearchWorkItems();
            }

        }
    }
}
