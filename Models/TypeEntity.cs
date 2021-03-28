using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class TypeEntity
    {
        public TypeEntity()
        {
            TechniqueTypes = new HashSet<TechniqueType>();
            TypeNames      = new HashSet<TypeName>();
        }

        public int       Id        { get; set; }
        public DateTime  Created   { get; set; }
        public DateTime? Updated   { get; set; }
        public string    CreatedBy { get; set; }
        public string    UdatedBy  { get; set; }

        public virtual ICollection<TechniqueType> TechniqueTypes { get; set; }
        public virtual ICollection<TypeName>      TypeNames      { get; set; }
    }
}