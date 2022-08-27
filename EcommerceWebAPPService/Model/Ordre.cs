using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebAPPService.Model
{
    public class Ordre
    {
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ? ProductId { get; set; }
        public Product ? Product { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
