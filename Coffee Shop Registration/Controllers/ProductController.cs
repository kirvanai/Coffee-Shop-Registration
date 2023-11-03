using Coffee_Shop_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Shop_Registration.Controllers
{
    
    public class ProductController : Controller
    {
        public CoffeeShopContext db = new CoffeeShopContext();

        public IActionResult Index()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Product(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }


    }
}