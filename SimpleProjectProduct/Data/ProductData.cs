using SimpleProjectProduct.Models;

namespace SimpleProjectProduct.Data;

public class ProductData
{
    private List<Product> _products = new List<Product>();

    public Product AddProduct(Product product)
    {
        product.Id = new Random().Next();
        _products.Add(product);
        return product;
    }
}