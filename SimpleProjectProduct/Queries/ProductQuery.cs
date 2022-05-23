using GraphQL.Types;
using SimpleProjectProduct.EntityFramework;
using SimpleProjectProduct.Models;

namespace SimpleProjectProduct.Queries;

public class ProductQuery : ObjectGraphType
{
    public ProductQuery()
    {
        Field<ListGraphType<ProductType>>("product", resolve: context =>
        {
          var productContext = context.RequestServices.GetRequiredService<ProductContext>();
            return productContext.Products;
        });
    }
}

/*new List<Product> {
      new Product { Estoque = 321, Nome = "Helloo", Preco = 3.75},
      new Product { Estoque = 2131, Nome = "Hello World! How are you?" , Preco = 897},
      new Product { Estoque = 78678, Nome = "Hello World!" , Preco = 124.22},
      new Product { Estoque = 65, Nome = "How are you?" , Preco = 5678},
      new Product { Estoque = 667, Nome = "Are you?" , Preco = 1.99}
    }*/