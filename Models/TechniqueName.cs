using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class TechniqueName
    {
        public int NameId { get; set; }
        public int TechniqueId { get; set; }

        public virtual Technique Technique { get; set; }
    }
}
