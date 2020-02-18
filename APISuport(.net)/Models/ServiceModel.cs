using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APISupport.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Issueid { get; set; }
        public int SupporterId { get; set; }

        public virtual Issue1 Issue1 { get; set; }
        public virtual Supporter Supporter { get; set; }
    }
}