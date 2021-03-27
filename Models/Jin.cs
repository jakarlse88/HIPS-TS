using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class Jin
    {
        public Jin()
        {
            JinNames = new HashSet<JinName>();
            Techniques = new HashSet<Technique>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<JinName> JinNames { get; set; }
        public virtual ICollection<Technique> Techniques { get; set; }
    }
}
