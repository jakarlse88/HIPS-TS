#nullable disable

namespace HIPS_TS.Models
{
    public partial class TechniqueCategory
    {
        public int TechniqueId { get; set; }
        public int CategoryId  { get; set; }

        public virtual Category  Category  { get; set; }
        public virtual Technique Technique { get; set; }
    }
}