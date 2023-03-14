using Microsoft.EntityFrameworkCore;
using PetShopWebApp.Models.Entities;

namespace PetShopWebApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Property(p => p.UnitPrice).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,4)");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get;}
        public DbSet<OrderDetail> OrderDetails { get;}
        public DbSet<CartItem> CartItems { get;}

        
    }
}
