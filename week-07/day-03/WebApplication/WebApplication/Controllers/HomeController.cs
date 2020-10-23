using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private PrinterService printerService;

        public HomeController()
        {
            printerService=new PrinterService();
             
        }
        public IActionResult Index(PrinterService)
        {
            var model = new IndexViewModel()
            {
                Printer = printerService.PrintLog();
                message = "Hello";
            };
            return View(model);
        }
    }
}