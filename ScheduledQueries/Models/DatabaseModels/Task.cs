using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class Task
    {
        public int TaskId { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Creator { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<TaskExecution> Executions { get; set; }
        public virtual ICollection<TaskOutput> Outputs { get; set; }
        public virtual ICollection<TaskQueryAssoc> TaskQueryAssocs { get; set; }
    }
}