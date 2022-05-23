using Microsoft.EntityFrameworkCore;
using SimpleProjectProduct.EntityFramework;
using SimpleProjectProduct.Models;

namespace SimpleProjectProduct.Repository;
public class ProductRepository : IRepository
{
    private ProductContext _productDbContext;
    public ProductRepository(ProductContext productDbContext){
        _productDbContext = productDbContext;
        _productDbContext.Database.EnsureCreated();
    }
    public async Task<Product> AddItem(Product item)
    {               
        _productDbContext.Products.Add(item);
        _productDbContext.SaveChanges();
        return await _productDbContext.Products.Where(n=>n.Nome == item.Nome).FirstOrDefaultAsync();
    }

    public Task<Product> GetProductById(int id)
    {
        return _productDbContext.Products.FirstAsync(i => i.Id.Equals(id));
    }

    public Task<Product> GetProductByName(string name)
    {
        return _productDbContext.Products.FirstAsync(i => i.Nome.Equals(name));
    }
}