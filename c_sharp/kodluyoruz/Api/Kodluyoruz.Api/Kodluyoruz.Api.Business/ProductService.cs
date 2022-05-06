using KodluyoruzTest.DataAccess.Repositories;
using KodluyoruzTest.Entities;

namespace KodluyoruzTest.Business
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
