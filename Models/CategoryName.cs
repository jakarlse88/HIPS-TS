#nullable disable

namespace HIPS_TS.Models
{
    public partial class CategoryName
    {
        public int NameId     { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}