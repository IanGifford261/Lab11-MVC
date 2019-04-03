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
        public IActionResult Index(int minimumPoints, int maximumPrice)
        {
            return RedirectToAction("Results", new { minimumPoints, maximumPrice });
        }

        [HttpGet]
        public IActionResult Results(int minimumPoints, int maximumPrice)
        {
            List<Wine> wineList = Wine.GetWineList(minimumPoints, maximumPrice);
            return View(wineList);
        }

    }
}
