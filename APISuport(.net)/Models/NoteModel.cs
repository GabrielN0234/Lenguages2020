using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISupport.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string Dscription { get; set; }
        public System.DateTime NoteTimestamp { get; set; }
        public int Issueid { get; set; }
        public int SupervisorId { get; set; }
        public int SupporterId { get; set; }

        public virtual Issue1 Issue1 { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual Supporter Supporter { get; set; }
    }
}