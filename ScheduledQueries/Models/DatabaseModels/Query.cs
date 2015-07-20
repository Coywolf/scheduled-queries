using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class Query
    {
        public int QueryId { get; set; }

        public virtual ICollection<QueryVersion> Versions { get; set; }
        public virtual ICollection<TaskQueryAssoc> TaskQueryAssocs { get; set; }
    }
}