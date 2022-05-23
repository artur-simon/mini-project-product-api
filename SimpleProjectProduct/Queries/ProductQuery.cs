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