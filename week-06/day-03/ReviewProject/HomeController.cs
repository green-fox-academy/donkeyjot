using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewProject.NewFolder;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReviewProject
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet ("index")]
        public IActionResult Index()
        {
            var model = new Pirate("John", 34.2, PirateType.Captain);
            var pirate = model.ToString();

            return View(pirate);
        }

        [HttpGet("pirate")]
        public Pirate GetPirate()
        {
            var model = new Pirate("John", 34.2, PirateType.Captain);
            return model;
        }
    }
}
