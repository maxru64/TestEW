using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAutoPartsStore
    {
        IEnumerable<AutoPartsStore> AllAutoPartsStores { get; }
    }
}
