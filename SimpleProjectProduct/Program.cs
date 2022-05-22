using GraphQL;
using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using SimpleProjectProduct.Schemas;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// add notes schema
builder.Services.AddSingleton<ISchema, ProductSchema>(services => new ProductSchema(new SelfActivatingServiceProvider(services)));
// register graphQL
builder.Services.AddGraphQL(options => { options.EnableMetrics = true;}).AddSystemTextJson();
builder.Services.AddControllers();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
// make sure all our schemas registered to route
app.UseGraphQL<ISchema>();

app.Run();
