using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public enum TaskExecutionStatus
    {
        Pending,
        Success,
        Fail
    }

    public class TaskExecution
    {
        public int TaskExecutionId { get; set; }

        public int TaskId { get; set; }
        public int QueryVersionId { get; set; }

        public string Results { get; set; }
        public bool IsManual { get; set; }
        public TaskExecutionStatus Status { get; set; }
        public string Message { get; set; }
        public DateTime ExecutionDate { get; set; }

        public virtual Task Task { get; set; }
        public virtual QueryVersion QueryVersion { get; set; }
    }
}