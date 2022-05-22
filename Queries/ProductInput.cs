using System;

namespace AspnetCore_GraphQL.Queries
{
    public class ProductInput
    {
        public String Estoque { get; set; }
        public String Nome { get; set; }
        public double Preco { get; set; }

    }
}