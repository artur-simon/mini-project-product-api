using GraphQL;
using SimpleProjectProduct.Models;

namespace SimpleProjectProduct_Test;
public class ProjectTest
{ 

    Product novoProduto()
        {
            return new Product() { Estoque = 3, Nome = "Demo name", Preco = 5 };
        }
    }
