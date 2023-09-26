namespace ProxyPattern
{
    public class ProductsController
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository) => this.productRepository = productRepository;

        // [MyActionFilter] // Proxy
        public Product Get(int id) => productRepository.Get(id);
    }

   
}
