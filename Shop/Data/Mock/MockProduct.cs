using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;


namespace Shop.Data.Mock
{
    public class MockProduct : IProduct
    {
        public IEnumerable<Product> AllProduct
        {
            get
            {
                return new List<Product> {
                            new Product { Id = 1, Name = "Суппорт"},
                            new Product { Id = 2, Name = "Мотор"}
                };
            }
        }
    }
}
