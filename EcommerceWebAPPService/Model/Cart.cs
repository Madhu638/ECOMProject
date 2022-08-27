using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebAPPService.Model
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ? CartId { get; set; }
        public string? ProductId { get; set; }
        public Product ? Product { get; set; }
        public int Count { get; set; } = 0;
        public DateTime  DateCreated { get; set; } = DateTime.Now;
    }
}
