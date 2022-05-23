using SimpleProjectProduct.IService;
using SimpleProjectProduct.Models;
using SimpleProjectProduct.Models.Input;
using SimpleProjectProduct.EntityFramework;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Queries;
public class ProductMutation : ObjectGraphType
{
    public ProductMutation()
    {
        Field<ProductType>(
            "create",
            arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "message" }
                ),
                resolve: context =>
                {
                    var estoque = context.GetArgument<int>("Estoque");
                    var nome = context.GetArgument<string>("Nome");
                    var preco = context.GetArgument<double>("Preco");

                    var productContext = context.RequestServices.GetRequiredService<ProductContext>();
                    Product product = new Product { Estoque = estoque, Nome = nome, Preco = preco };
                    productContext.Products.Add(product);
                    productContext.SaveChanges();
                    return product;
                }

        );
    }
}