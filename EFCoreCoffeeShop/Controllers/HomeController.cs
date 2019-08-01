using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCoreCoffeeShop.Models;
using EFCoreCoffeeShop.CoffeeShop;

namespace EFCoreCoffeeShop.Controllers
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
        [HttpPost]
        public IActionResult NewUser(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                ViewBag.Error = "You Done Messed Up!";
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
