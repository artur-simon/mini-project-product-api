using SimpleProjectProduct.Models;

namespace SimpleProjectProduct.Repository;
    public interface IRepository
    {
        Task<Product> GetProductByName(string name);
        Task<Product> AddItem(Product item);
        Task<Product> GetProductById(int id);
    }