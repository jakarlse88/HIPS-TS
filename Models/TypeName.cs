#nullable disable

namespace HIPS_TS.Models
{
    public partial class TypeName
    {
        public int NameId { get; set; }
        public int TypeId { get; set; }

        public virtual TypeEntity Type { get; set; }
    }
}