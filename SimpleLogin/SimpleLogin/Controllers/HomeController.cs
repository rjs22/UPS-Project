using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleLogin.Data;
using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class HomeController : Controller
    {
        private readonly SimpleLoginContext _context;

        public HomeController(SimpleLoginContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["user"] = HttpContext.Session.GetInt32("UserID");
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string uName, string pass)
        {
            int id = _context.User.Where(x => x.UserName.Equals(uName) && x.Password.Equals(pass)).Select(x => x.ID).FirstOrDefault();
            
            if (id == 0)
            {
                return View("Login");
            }
            else
            {
                HttpContext.Session.SetInt32("UserID", id);
                return View("Index");
            }

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string uName,string pass,string fName,string lName)
        {
            var login = new Login
            {
                UserName = uName,
                Password = pass,
                FirstName = fName,
                LastName = lName
            };

            _context.User.Add(login);
            _context.SaveChanges();

            return View("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
