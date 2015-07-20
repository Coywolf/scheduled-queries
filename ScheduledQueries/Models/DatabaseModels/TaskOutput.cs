using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public enum TaskOutputTypes
    {
        Email,
        File
    }

    public class TaskOutput
    {
        public int TaskOutputId { get; set; }

        public int TaskId { get; set; }
        public TaskOutputTypes OutputType { get; set; }

        public virtual Task Task { get; set; }
    }
}