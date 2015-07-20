using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class TaskExecution
    {
        public int TaskExecutionId { get; set; }

        public int TaskId { get; set; }

        public virtual Task Task { get; set; }
    }
}