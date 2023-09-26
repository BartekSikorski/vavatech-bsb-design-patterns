using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace ProxyPattern
{
    public interface IProductRepository
    {
        Product Get(int id);
    }

    public class DbProductRepository : IProductRepository
    {
        private readonly IDictionary<int, Product> products;

        public DbProductRepository()
        {
            products = new Dictionary<int, Product>()
            {
                { 1, new Product(1, "Product 1", 10) },
                { 2, new Product(2, "Product 2", 20) },
                { 3, new Product(3, "Product 3", 30) },
            };
        }

        public Product Get(int id)
        {
            Thread.Sleep(1000);

            if (products.TryGetValue(id, out Product product))
            {
                return product;
            }
            else
                return null;
        }
    }


}
