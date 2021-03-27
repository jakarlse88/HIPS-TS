using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class TypeName
    {
        public int NameId { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
    }
}
