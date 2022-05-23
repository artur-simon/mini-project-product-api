using SimpleProjectProduct.Models;
using SimpleProjectProduct.EntityFramework;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleProjectProduct.Repository;

namespace SimpleProjectProduct.Queries;
public class ProductMutation : ObjectGraphType
{
    public ProductMutation(IRepository repository)
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

                    return repository.AddItem(product);
                }
        );

        Field<ProductType>(
            "edit",
            arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" },
                    new QueryArgument<IntGraphType> { Name = "estoque" },
                    new QueryArgument<StringGraphType> { Name = "nome" },
                    new QueryArgument<FloatGraphType> { Name = "preco" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    int? estoque = context.GetArgument<int?>("estoque", defaultValue:null);
                    String nome = context.GetArgument<string>("nome");
                    double? preco = context.GetArgument<double?>("preco", defaultValue:null);

                    var productContext = context.RequestServices.GetRequiredService<ProductContext>();
                    var product = productContext.Products.Find(id);
                    if(product != null){
                        if (preco != null) product.Preco = (double)preco;
                        if (nome != null) product.Nome = nome;
                        if (estoque != null) product.Estoque = (int)estoque;
                        productContext.SaveChanges();
                    }
                    return product;
                }
        );

        Field<ProductType>(
            "delete",
            arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    var productContext = context.RequestServices.GetRequiredService<ProductContext>();
                    var product = productContext.Products.Find(id);
                    productContext.Products.Remove(product);
                    productContext.SaveChanges();

                    return product;
                }
        );
        
    }
}