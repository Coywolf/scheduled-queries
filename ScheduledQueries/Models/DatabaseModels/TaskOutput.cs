using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public enum TaskOutputType
    {
        Email,
        File
    }

    public class TaskOutput
    {
        public int TaskOutputId { get; set; }

        public int TaskId { get; set; }
        public TaskOutputType OutputType { get; set; }

        public virtual Task Task { get; set; }
    }
}