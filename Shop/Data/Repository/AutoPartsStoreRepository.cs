using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class AutoPartsStoreRepository : IAutoPartsStore
    {

        private readonly ApplicationContext _applicationContext;

        public AutoPartsStoreRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<AutoPartsStore> AllAutoPartsStores => _applicationContext.AutoPartsStore;
    }
}
