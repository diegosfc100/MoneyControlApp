using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyNote.Models
{
    public class Category
    {
        [Key]
        public int CaregoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int Icon { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public int Title { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public int Type { get; set; }
    }
}
