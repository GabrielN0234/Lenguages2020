using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISupport.Models
{
    public class IssueModel
    {
        public int id { get; set; }
        public int ReportNumber { get; set; }
        public string Classification { get; set; }
        public string Status { get; set; }
        public System.DateTime RaportTimestamp { get; set; }
        public string ResolutionComment { get; set; }
        public int SupervisorId { get; set; }
        public int SupporterId { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notes> Notes { get; set; }
        public virtual Supporter Supporter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service1> Service1 { get; set; }
    }
}