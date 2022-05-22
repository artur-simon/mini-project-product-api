using GraphQL.Types;
using SimpleProjectProduct.Queries;

namespace SimpleProjectProduct.Schemas;

public class ProductSchema : Schema
{
    public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<RetrieveQuery>();
    }
}