using GraphQL.Types;

namespace SimpleProjectProduct.Models;

public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";
            Field(x => x.Id).Description("Id");
            Field(x => x.Estoque).Description("Estoque");
            Field(x => x.Nome).Description("Nome do produto");
            Field(x => x.Preco).Description("Preço");
        }
    }
