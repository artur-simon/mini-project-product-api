using SimpleProjectProduct.IService;
using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Queries;
public class Mutation
{
    private readonly IService.IProductService _productService = null;
    public Mutation(IService.IProductService productService)
    {
        _productService = productService;
    }
}