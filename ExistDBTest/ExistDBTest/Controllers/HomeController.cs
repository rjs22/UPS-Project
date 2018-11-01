using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExistDBTest.Models;
using ExistDBTest.Data;

namespace ExistDBTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExistDBTestContext _context;

        public HomeController(ExistDBTestContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            ViewData["example"] = _context.testTbl.Where(c => c.ID == 23).Select(c => c.gfield1).SingleOrDefault();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
