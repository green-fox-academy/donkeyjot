using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
               
            };

            return View(greeting);

        }
    }
}
