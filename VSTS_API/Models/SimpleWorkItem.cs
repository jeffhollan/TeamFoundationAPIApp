using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSTS_API.Models
{
    public class SimpleWorkItem
    {
        //Title = "Parking Lot Backlog",
        //        AreaPath = @"RD\Azure App Plat\Logic Apps",
        //        State = "New",
        //        IterationPath = @"RD\Azure App Plat\Logic Apps"

        public string Type { get; set; }
        public string Title { get; set; }
        public string AreaPath { get; set; }
        public string State { get; set; }
        public string IterationPath { get; set; }
        public string LinkType { get; set; }
        public int LinkId { get; set; }

        public int id { get; set; }
        public string AssignedTo { get; set; }
        public string HowFound { get; set; }

        public int Priority { get; set; }
    }

    public class BasicQuery
    {
        public string query { get; set; }
        public string type { get; set; }

    }
}