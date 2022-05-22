using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.IService;

public interface IProductService
{
    IQueryable<Product> getAll();
    IQueryable<Product> getByFilter(ProductInput input);
    void create(ProductInput input);
    void delete(ProductInput input);
    void update(ProductInput input);
}
