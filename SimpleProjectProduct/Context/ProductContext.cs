using SimpleProjectProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleProjectProduct.EntityFramework;
public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductContext(DbContextOptions options) : base(options)
    {
        
    }
}