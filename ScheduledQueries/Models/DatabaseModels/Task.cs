using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public enum ScheduleType 
    {
        Single,
        Daily,
        Weekly,
        Monthly
    }
    
    public class Task
    {
        public int TaskId { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }
        public ScheduleType ScheduleType { get; set; }

        // all types
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // daily
        public int RecurDays { get; set; }

        // weekly
        public int RecurWeeks { get; set; }

        // monthly

        public bool IsDisabled { get; set; }

        [MaxLength(256)]
        public string Creator { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<TaskExecution> Executions { get; set; }
        public virtual ICollection<TaskOutput> Outputs { get; set; }
        public virtual ICollection<TaskQueryAssoc> TaskQueryAssocs { get; set; }
    }
}