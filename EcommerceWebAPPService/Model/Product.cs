using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceWebAPPService.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Title { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ProdName { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string? ProdDetails { get; set; }
        public string? Catagory { get; set; }
        public int Price { get; set; }

        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
    }
        
}
