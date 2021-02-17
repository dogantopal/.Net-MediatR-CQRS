using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Helpers
{
    public interface IDataHelper
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
    }
}
