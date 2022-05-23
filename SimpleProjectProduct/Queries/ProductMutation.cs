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
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "estoque" },
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "nome" },
                    new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "preco" }
                ),
                resolve: context =>
                {
                    var estoque = context.GetArgument<int>("estoque");
                    var nome = context.GetArgument<string>("nome");
                    var preco = context.GetArgument<double>("preco");
                    Product product = new Product { Estoque = estoque, Nome = nome, Preco = preco };

                    var productContext = context.RequestServices.GetRequiredService<ProductContext>();
                    productContext.Products.Add(product);
                    productContext.SaveChanges();
                    return product;
                }
        );
        Field<ProductType>(
            "edit",
            arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "estoque" },
                    new QueryArgument<StringGraphType> { Name = "nome" },
                    new QueryArgument<FloatGraphType> { Name = "preco" }
                ),
                resolve: context =>
                {
                    var estoque = context.GetArgument<int>("estoque");
                    var nome = context.GetArgument<string>("nome");
                    var preco = context.GetArgument<double>("preco");
                    Product product = new Product { Estoque = estoque, Nome = nome, Preco = preco };

                    var productContext = context.RequestServices.GetRequiredService<ProductContext>();
                    productContext.Products.Add(product);
                    productContext.SaveChanges();
                    return product;
                }
        );
    }
}