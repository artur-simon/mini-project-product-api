using GraphQL.Types;
using System;

namespace SimpleProjectProduct.Models.Input;
public class ProductInput : InputObjectGraphType<Product>
{
    public int Id { get; set; }
    public int Estoque { get; set; }
    public String Nome { get; set; }
    public double Preco { get; set; }
    
    public ProductInput()
    {
        Field(x => x.Id);
        Field(x => x.Nome);
        Field(x => x.Estoque);
        Field(x => x.Preco);
    }
}