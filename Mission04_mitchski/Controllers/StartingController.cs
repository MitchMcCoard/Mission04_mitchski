using Microsoft.AspNetCore.Mvc;
using Mission04_mitchski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_mitchski.Controllers
{
    public class StartingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator ()
        {
            return View();
        }

        //You can overload this because it has a different signature (meaning it recieves a parameter when the "get" doesn't)
        [HttpPost] //Called an attribute
        public IActionResult Calculator (CalculatorModel model)
        {
            return View();
        }
    }
}
