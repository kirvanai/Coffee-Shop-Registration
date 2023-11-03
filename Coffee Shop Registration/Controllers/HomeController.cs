using Coffee_Shop_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        //public CoffeeShopContext db = new CoffeeShopContext();
       
        public IActionResult Index()
        {
            //List<Product> products = db.Products.ToList();
            //return View(products);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult User(User u)
        {
            return View(u);
        }
        
        public IActionResult Register()
        {
            return View();
        }

        //public IActionResult Product(int Id)
        //{
        //    Product p = db.Products.Find(Id);
        //    return View(p);
        //}
   
    
    }
}