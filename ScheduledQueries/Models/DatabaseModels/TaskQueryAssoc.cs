using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class TaskQueryAssoc
    {
        [Key, Column(Order=1)]
        public int TaskId { get; set; }

        [Key, Column(Order = 2)]
        public int QueryId { get; set; }

        public virtual Task Task { get; set; }
        public virtual Query Query { get; set; }
    }
}