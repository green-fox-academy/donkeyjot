using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DIApp.Interfaces;
using DIApp.Entities;
using DIApp.Servies;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DIApp.Controllers
{
    public class HomeController : Controller
    {
        private IPrinterService printerService;

        public HomeController(IPrinterService printerService)
        {
            this.printerService = printerService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
