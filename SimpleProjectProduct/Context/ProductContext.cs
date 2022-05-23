using SimpleProjectProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleProjectProduct.EntityFramework;
public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Estoque = 321, Nome = "Helloo", Preco = 3.75},
            new Product { Estoque = 2131, Nome = "Hello World! How are you?" , Preco = 897},
            new Product { Estoque = 78678, Nome = "Hello World!" , Preco = 124.22},
            new Product { Estoque = 65, Nome = "How are you?" , Preco = 5678},
            new Product { Estoque = 667, Nome = "Are you?" , Preco = 1.99}
        );
    }
}