using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISupport.Models
{
    public class SupervisorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string FirstSurname { get; set; }
        public string Email { get; set; }
        public int SupporterId { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issue1> Issue1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notes> Notes { get; set; }
        public virtual Supporter Supporter { get; set; }
    }
}