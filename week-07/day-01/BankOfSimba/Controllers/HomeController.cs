using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("show")]
        public IActionResult Show()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "lion");
            ViewData["name"] = bankAccount.Name;
            ViewBag.Balance = bankAccount.Balance;
            ViewData["animal"] = bankAccount.AnimalType;

            return View("Index", bankAccount);
        }
    }
}

