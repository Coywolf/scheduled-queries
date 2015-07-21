using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScheduledQueries.Models.DatabaseModels
{
    public class QueryVersion
    {
        public int QueryVersionId { get; set; }

        public int QueryId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Query Query { get; set; }
    }
}