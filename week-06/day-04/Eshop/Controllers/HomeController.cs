using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eshop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eshop
{
    public class HomeController : Controller
    {
        [HttpGet]
        public string Home()
        {
            return "Hello world";
        }

        [HttpGet]
        public IActionResult Index()
        {
            ItemList list = new ItemList("/Users/ondra/Documents/greenfox/donkeyjot/week-06/day-04/Eshop/Database/db.txt");
            return View(list);
        }

        [HttpGet]
        public IActionResult AvailableOnes()
        {
            ItemList list = new ItemList("/Users/ondra/Documents/greenfox/donkeyjot/week-06/day-04/Eshop/Database/db.txt");
            list.GetAvailable();
            return View("Index", list);
        }

        [HttpGet]
        public IActionResult CheapestFirst()
        {
            ItemList list = new ItemList("/Users/ondra/Documents/greenfox/donkeyjot/week-06/day-04/Eshop/Database/db.txt");
            list.CheapestFirst();
            return View("Index", list);
        }

        [HttpGet]
        public IActionResult ContainsSpecialized()
        {
            ItemList list = new ItemList("/Users/ondra/Documents/greenfox/donkeyjot/week-06/day-04/Eshop/Database/db.txt");
            list.IsContaining("specialized");
            return View("Index", list);
        }


        [HttpGet]
        public IActionResult AverageStock()
        {
            ItemList list = new ItemList("/Users/ondra/Documents/greenfox/donkeyjot/week-06/day-04/Eshop/Database/db.txt");

            ViewData["average"] = list.GetAverageStock();

            return View(list);
        }
    }
}
