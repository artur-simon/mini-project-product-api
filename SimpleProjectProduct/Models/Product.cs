using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProjectProduct.Models;

public class Product
{
    private double preco;
    public int Id { get; set; }
    public int Estoque { get; set; }
    public String Nome { get; set; }
    public double Preco
    {
        get { return preco; }
        set { preco = value > 0 ? value : 0; }
    }
}