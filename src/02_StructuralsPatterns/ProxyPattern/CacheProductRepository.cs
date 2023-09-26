using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProxyPattern
{

    //public class CacheProductRepositoryClass : DbProductRepository, IProductRepository
    //{

    //    public override Product Get(int id)
    //    {
    //        // TODO: add cache

    //        return base.Get(id);
    //    }
    //}

    // OrderProxy : Order
    // Console.WriteLine(Order.Customer.Name);

    // Pośrednik (Proxy)
    // Wariant obiektowy
    public class CacheProductRepository : IProductRepository
    {
        private IDictionary<int, Product> products;

        // Real Subject
        private readonly IProductRepository productRepository;

        public CacheProductRepository(IProductRepository productRepository)
        {
            products = new Dictionary<int, Product>();

            this.productRepository = productRepository;
        }

        public void Add(Product product)
        {
            products.Add(product.Id, product);
        }

        public Product Get(int id)
        {
            if (products.TryGetValue(id, out Product product))
            {
                product.CacheHit++;

                return product;
            }
            else
            {
                product = productRepository.Get(id);

                if (product != null)
                {
                    Add(product);
                }

                return product;
            }
        }

    }

}
