using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Persistance.Context;

public class OrderContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=MultiShopOrderDb;User Id=sa;Password=Aaa...İst!;TrustServerCertificate=True");
    }
    
    public DbSet<Address>  Addresses { get; set; }
    public DbSet<OrderDetail>  OrderDetails { get; set; }
    public DbSet<Ordering>  Orderings { get; set; }
}