using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class Description
    {
        public Description()
        {
            TechniqueDescriptions = new HashSet<TechniqueDescription>();
        }

        public int       Id         { get; set; }
        public string    Body       { get; set; }
        public DateTime  Created    { get; set; }
        public DateTime? Updated    { get; set; }
        public string    CreatedBy  { get; set; }
        public string    UpdatedBy  { get; set; }
        public int       LanguageId { get; set; }

        public virtual ICollection<TechniqueDescription> TechniqueDescriptions { get; set; }
    }
}