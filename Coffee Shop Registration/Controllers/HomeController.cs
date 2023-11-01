using Coffee_Shop_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
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
    
    }
}