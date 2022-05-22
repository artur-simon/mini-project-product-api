using GraphQL.Types;
using SimpleProjectProduct.Models;

namespace SimpleProjectProduct.Queries;

public class RetrieveQuery : ObjectGraphType
{
  public RetrieveQuery()
  {
    Field<ListGraphType<ProductType>>("product", resolve: context => new List<Product> {
      new Product { Estoque = 321, Nome = "Helloo", Preco = 3.75},
      new Product { Estoque = 2131, Nome = "Hello World! How are you?" , Preco = 124.22}
    });
  }
}