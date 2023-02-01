using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Calculator ()
        {
            return View();
        }
    }
}
