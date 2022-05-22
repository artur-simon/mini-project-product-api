using SimpleProjectProduct.IService;
using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.Services;
using SimpleProjectProduct.Data;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Queries;
public class ProductMutation : ObjectGraphType
{
    public ProductMutation(ProductData data)
    {
        Field<ProductType>(
            "createProduct",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductType>> {}),
            resolve: context =>
            {
                var product = context.GetArgument<Product>("id");
                return data.AddProduct(product);
            });
    }
}