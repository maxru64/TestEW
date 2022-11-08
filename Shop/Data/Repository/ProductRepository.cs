using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationContext _applicationContext;
        public ProductRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<Product> AllProduct => _applicationContext.Product.Include(c => c.AutoPartsStores);
    }
}
