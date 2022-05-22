using GraphQL.Types;
using SimpleProjectProduct.Queries;

namespace SimpleProjectProduct.Schemas;

public class ProductSchema : Schema
{
    public ProductSchema(IServiceProvider provider) : base(provider)
    {
        Query = provider.GetRequiredService<ProductQuery>();
        Mutation  = provider.GetRequiredService<ProductMutation>();
    }
}