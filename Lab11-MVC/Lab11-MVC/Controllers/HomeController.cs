using Microsoft.AspNetCore.Mvc;
using Lab11_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int minimumPrice, int maximumPrice)
        {
            return RedirectToAction("Results", new { minimumPrice, maximumPrice });
        }

        [HttpGet]
        public IActionResult Results(int minimumPrice, int maximumPrice)
        {
            List<Wine> wineList = Wine.GetWineList(minimumPrice, maximumPrice);
            return View(wineList);
        }

    }
}
