using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;

namespace Shop.Controllers
{
    public class AutoPartsStoreController : Controller
    {
        private readonly IAutoPartsStore _autoPartsStore;
        public AutoPartsStoreController(IAutoPartsStore autoPartsStore) {
            _autoPartsStore = autoPartsStore;
        }
        public ActionResult ListAutoPartsStore()
        {
            var AutoPartsStore = _autoPartsStore.AllAutoPartsStores;
            return View(AutoPartsStore);
        }
    }
}
