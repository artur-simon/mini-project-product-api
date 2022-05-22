using SimpleProjectProduct.IService;
using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Services;
public class ProductService : IProductService
{
    private IList<Product> _product;
    public ProductService() { _product = new List<Product>(); }

    public void create(ProductInput input)
    {
        throw new NotImplementedException();
    }

    public void delete(ProductInput input)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Product> getAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<Product> getByFilter(ProductInput input)
    {
        throw new NotImplementedException();
    }

    public void update(ProductInput input)
    {
        throw new NotImplementedException();
    }
}