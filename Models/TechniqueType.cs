using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class TechniqueType
    {
        public int TechniqueId { get; set; }
        public int TypeId { get; set; }

        public virtual Technique Technique { get; set; }
        public virtual Type Type { get; set; }
    }
}
