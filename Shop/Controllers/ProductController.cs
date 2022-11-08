using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;


namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        public ActionResult ListProduct(int id)
        {
            var productsList = _product.AllProduct.Where(p => p.AutoPartsStores.Any(a => a.Id == id));
            return View(productsList);
        }
    }
}
