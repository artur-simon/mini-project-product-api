using GraphQL.Types;
using System;

namespace SimpleProjectProduct.Models.Input;
public class ProductInput : InputObjectGraphType<Product>
{
    public ProductInput()
    {
        Field(x => x.Nome);
        Field(x => x.Estoque);
        Field(x => x.Preco);
    }
}