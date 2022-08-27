using Microsoft.EntityFrameworkCore;

namespace EcommerceWebAPPService.Model.Context
{
    public class EcomContext : DbContext
    {
        public EcomContext(DbContextOptions option) : base(option)
        {

        }

        //public DbSet<Catagory> Catagory { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<Ordre> Order { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}