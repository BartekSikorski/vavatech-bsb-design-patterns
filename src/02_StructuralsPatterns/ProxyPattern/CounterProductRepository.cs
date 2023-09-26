namespace ProxyPattern
{
    // Proxy
    public class CounterProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;

        public CounterProductRepository(IProductRepository repository)
        {
            _repository = repository;
        }

        public int Counter { get; private set; }

        public Product Get(int id)
        {
            Counter++;
            return _repository.Get(id);
        }
    }

}
