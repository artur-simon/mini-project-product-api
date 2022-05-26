using System;
using System.Linq;
using SimpleProjectProduct.Models;

namespace SimpleProjectProduct_Test
{
    class TestProductDbSet : TestDbSet<Product>
    {
        public override Product Find(params object[] keyValues)
        {
            return this.SingleOrDefault(product => product.Id == (int)keyValues.Single());
        }
    }
}