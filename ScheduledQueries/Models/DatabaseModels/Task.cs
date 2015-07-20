using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<TaskExecution> Executions { get; set; }
        public virtual ICollection<TaskOutput> Outputs { get; set; }
        public virtual ICollection<TaskQueryAssoc> TaskQueryAssocs { get; set; }
    }
}