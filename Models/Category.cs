using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_TS.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryNames = new HashSet<CategoryName>();
            TechniqueCategories = new HashSet<TechniqueCategory>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<CategoryName> CategoryNames { get; set; }
        public virtual ICollection<TechniqueCategory> TechniqueCategories { get; set; }
    }
}
