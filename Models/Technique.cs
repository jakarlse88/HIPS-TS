using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class Technique
    {
        public Technique()
        {
            TechniqueCategories   = new HashSet<TechniqueCategory>();
            TechniqueDescriptions = new HashSet<TechniqueDescription>();
            TechniqueNames        = new HashSet<TechniqueName>();
            TechniqueTypes        = new HashSet<TechniqueType>();
        }

        public int       Id        { get; set; }
        public DateTime  Created   { get; set; }
        public DateTime? Updated   { get; set; }
        public string    CreatedBy { get; set; }
        public string    UpdatedBy { get; set; }
        public int?      JinId     { get; set; }

        public virtual Jin                               Jin                   { get; set; }
        public virtual ICollection<TechniqueCategory>    TechniqueCategories   { get; set; }
        public virtual ICollection<TechniqueDescription> TechniqueDescriptions { get; set; }
        public virtual ICollection<TechniqueName>        TechniqueNames        { get; set; }
        public virtual ICollection<TechniqueType>        TechniqueTypes        { get; set; }
    }
}