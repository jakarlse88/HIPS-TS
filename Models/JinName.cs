using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class JinName
    {
        public int JinId { get; set; }
        public int NameId { get; set; }

        public virtual Jin Jin { get; set; }
    }
}
