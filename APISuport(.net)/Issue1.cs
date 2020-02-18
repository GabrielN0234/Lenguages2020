//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APISupport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Issue1()
        {
            this.Notes = new HashSet<Notes>();
            this.Service1 = new HashSet<Service1>();
        }
    
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
