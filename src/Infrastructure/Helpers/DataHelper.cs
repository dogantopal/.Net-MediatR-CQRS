using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Helpers
{
    public class DataHelper : IDataHelper
    {
        private static readonly List<Product> _products = new List<Product>();

        public DataHelper()
        {
            if (_products.Any()) return;

            _products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kalem",
                Price = 12
            });

            _products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Telefon",
                Price = 150
            });
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
