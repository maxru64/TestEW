using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> AllProduct { get; }
    }
}
