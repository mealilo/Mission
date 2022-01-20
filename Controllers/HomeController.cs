using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Home Page returns index view
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Grades model)
        {

            return View();
        }

        //Calculator returns calcator view
        public IActionResult Calculator()

        {
            ViewData["Title"] = "Calculator";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
