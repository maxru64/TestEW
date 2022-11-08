using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mock
{
    public class MockAutoPart : IAutoPartsStore
    {
        public IEnumerable<AutoPartsStore> AllAutoPartsStores
        {
            get
            {
                return new List<AutoPartsStore> {
                            new AutoPartsStore { Id = 1, Name = "Gomel"},
                            new AutoPartsStore { Id = 2, Name = "Minsk"}
                };
            }
        }
    }
}
