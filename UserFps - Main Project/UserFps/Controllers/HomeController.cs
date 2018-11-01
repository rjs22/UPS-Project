using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using UserFps.Classes;
using UserFps.Models;

namespace UserFps.Controllers
{
    public class HomeController : Controller
    {
        // Dependency injection.
        private readonly IHostingEnvironment _hostingEnvironment; // used for executing JS within the C# environment
        private readonly UserContext _context;                    // DB context for project

        // Associating the DI to a global environment to be accessed by all methods
        public HomeController(IHostingEnvironment hostingEnvironment,
                              UserContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Method will grab everything within a JS file as a string and add it to the DB along with the name of the vendor.
        // Only used when the vendor table does not have the code for injection. Displays the code added in the return.
        // How to use: Uncomment the link in "_Layout.cshtml", run the program and click on the link.
        // Code and name are stored in the DB and terminate the program. Return here to comment the name and code used and uncomment the next set.
        // Repeat process untill all necessary code is added to the DB.
        public JavaScriptResult GetJS()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            string VendorName = "ioaa";
            //string VendorName = "iobb";
            //string VendorName = "iocc";
            //string VendorName = "iodd";
            //string VendorName = "ioee";
            //string VendorName = "ioff";
            string result = System.IO.File.ReadAllText(webRootPath + "/js/async_anon.js");
            //string result = System.IO.File.ReadAllText(webRootPath + "/js/black_box.js");
            //string result = System.IO.File.ReadAllText(webRootPath + "/js/call_collect.js");
            //string result = System.IO.File.ReadAllText(webRootPath + "/js/device_devour.js");
            //string result = System.IO.File.ReadAllText(webRootPath + "/js/electric_entangle.js");
            //string result = System.IO.File.ReadAllText(webRootPath + "/js/function_feeder.js");

            var testEnt = new Vendor
            {
                VendorName = VendorName,
                VendorCode = result,
                ServiceActive = false
            };

            _context.Vendor.Add(testEnt);
            _context.SaveChanges();

            return new JavaScriptResult(result);
        }
    }
}
