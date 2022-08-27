using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EcommerceWebAPPService.Model
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
