using GraphQL.MicrosoftDI;
using GraphQL.SystemTextJson;
using SimpleProjectProduct.EntityFramework;
using Microsoft.EntityFrameworkCore;
using SimpleProjectProduct.Schemas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// register graphQL
builder.Services.AddGraphQL(b => b
.AddSelfActivatingSchema<ProductSchema>()
.AddSystemTextJson());
builder.Services.AddControllers();
builder.Services.AddDbContext<ProductContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
// make sure all our schemas registered to route
app.UseGraphQL<ProductSchema>();

app.Run();
