using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpSimulator.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpSimulator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Simp simp1 = new Simp("Ismael ReSimpo",9001, 10000, "omega", 11, new DateTime(1998, 5, 9, 8, 30, 50));
            Simp simp2 = new Simp("Kazuya Cuck", 100, 200, "beta", 5, new DateTime(2021, 10, 2, 14, 0, 0));

            List<Simp> simps = new List<Simp>();
            simps.Add(simp1);
            simps.Add(simp2);

            ViewBag.simps = simps;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
