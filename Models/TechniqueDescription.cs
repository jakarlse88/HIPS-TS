#nullable disable

namespace HIPS_TS.Models
{
    public partial class TechniqueDescription
    {
        public int TechniqueId   { get; set; }
        public int DescriptionId { get; set; }

        public virtual Description Description { get; set; }
        public virtual Technique   Technique   { get; set; }
    }
}