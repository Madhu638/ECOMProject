using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceWebAPPService.Model
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? OrderId { get; set; }
        public Ordre? Ordre { get; set; }
        public string? OrderDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? email { get; set; }
        public string? Total { get; set; }
    }
}
