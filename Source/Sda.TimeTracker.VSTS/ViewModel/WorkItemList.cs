using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sda.TimeTracker.VSTS.ViewModel
{
    public class WorkItemList
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string State { get; set; }

        public string TeamProject { get; set; }
        public string Priority { get; set; }

        public double OriginalEstimate { get; set; }

        public double RemainingWork { get; set; }

        public double CompletedWork { get; set; }

        
        public WorkItem WorkItem { get; set; }

    }
}
