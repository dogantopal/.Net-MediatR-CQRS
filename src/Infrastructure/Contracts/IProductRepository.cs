using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Contracts
{
    public interface IProductRepository 
    {
        Task<List<Product>> GetProductsAsync();
        Task<bool> CreateProductAsync(Product product);
    }
}
