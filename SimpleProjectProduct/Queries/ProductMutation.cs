using SimpleProjectProduct.IService;
using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.Services;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Queries;
public class ProductMutation : ObjectGraphType
{
    private readonly IService.IProductService _productService = null;
    public ProductMutation(IService.IProductService productService)
    {
        _productService = productService;
    }
}