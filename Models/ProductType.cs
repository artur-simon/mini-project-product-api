using GraphQL.Types;

namespace SimpleProjectProduct.Models{
    public class ProductType : ObjectGraphType<Product>
        {
            public ProductType()
            {
                Name = "Product";
                
                Field(x => x.CodigoBarras).Description("Código de Barras");

                Field(x => x.Nome).Description("Nome do produto");

                Field(x => x.Preco).Description("Preço");

            }
        }
}