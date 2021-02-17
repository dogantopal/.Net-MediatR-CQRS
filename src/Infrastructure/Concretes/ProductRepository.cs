using Domain;
using Infrastructure.Contracts;
using Infrastructure.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Concretes
{
    public class ProductRepository : IProductRepository
    {
        //Data helper could be any orm tools such as dapper, ef.
        private readonly IDataHelper _dataHelper;

        public ProductRepository(IDataHelper dataHelper)
        {
            _dataHelper = dataHelper;
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            await Task.CompletedTask;

            var products = _dataHelper.GetProducts();

            if (products.Any(x => x.Id == product.Id))
                return false;

            _dataHelper.AddProduct(product);

            return true;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            await Task.CompletedTask;

            return _dataHelper.GetProducts();
        }
    }
}
