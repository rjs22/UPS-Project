using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoginTest.Classes;
using LoginTest.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDBEx.Models;

namespace MongoDBEx.Controllers
{
    public class HomeController : Controller
    {
        // DI
        private readonly MongoDBExContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        // global references
        public HomeController(MongoDBExContext context,
                              IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        private IMongoDatabase mongoDatabase; // global variable
        
        //method that looks for MongoDB server and sets the DB
        public IMongoDatabase GetMongoDatabase()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            return mongoClient.GetDatabase("testDB");
        }

        public IActionResult Index()
        {
            return View();
        }

        // Method to insert JS into SQL DB (didn't have the time to convert the code back into a regular object so this was faster for me)
        public JavaScriptResult GetJS()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            string VendorName = "ioff";
            string result = System.IO.File.ReadAllText(webRootPath + "/js/extended_vendor.js");

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

        [HttpGet]// gets the code and loads it to the front-end
        public IActionResult JSONtoMongo()
        {
            // looking for code that produces JSON object from SQL DB
            var vendorCode = _context.Vendor.Where(x => x.VendorName == "ioff").Select(x => x.VendorCode).FirstOrDefault();
            ViewData["code"] = vendorCode; // taking the result and throwing it in the front-end for the JS to run

            return View();
        }

        [HttpPost]// processes action and shows result which should be inserting a JSON object into a MongoDB collection
        public IActionResult JSONtoMongo(string ven6)
        {
            mongoDatabase = GetMongoDatabase();
            var document = BsonSerializer.Deserialize<BsonDocument>(ven6); // taking in the whole JSON object and deserialize it
            mongoDatabase.GetCollection<BsonDocument>("test").InsertOne(document); // insert into collection

            return View();
        }

        // This method is now taking the object stored in the MongoDB collection and making use of all the parts.
        // There is extra code here that can be used to return the whole object if need be.
        // The LINQ calls are returning objects of the separate parts of the JSON. See the Models folder for a breakdown of how its calling one another.
        [HttpGet]
        public IActionResult MongotoCSharp()
        {
            mongoDatabase = GetMongoDatabase();
            var collection = mongoDatabase.GetCollection<MongoModel>("test");

            // Method 1 returns whole object (works)
            //var list = collection.Find(new BsonDocument()).ToList();
            //foreach (var dox in list)
            //{
            //    ViewData["return"] = dox;
            //}

            // Method 2 returns whole object (works)
            //await collection.Find(new BsonDocument()).ForEachAsync(X => ViewData["return"] =  X);
            
            // returns and object of the selected JSON object
            var navigator = collection.AsQueryable().Select(x => x.navigator).FirstOrDefault();
            var screen = collection.AsQueryable().Select(x => x.screen).FirstOrDefault();
            var extra = collection.AsQueryable().Select(x => x.extra).FirstOrDefault();
            var plugin = collection.AsQueryable().Select(x => x.plugins.ElementAt(1)).FirstOrDefault();

            // Display object to make sure they work
            ViewData["nav1"] = navigator.appCodeName;
            ViewData["nav2"] = navigator.build_ID;
            ViewData["nav3"] = navigator.oscpu;

            ViewData["scr1"] = screen.availHeight;
            ViewData["scr2"] = screen.height;
            ViewData["scr3"] = screen.pixelDepth;

            ViewData["ex1"] = extra.javascript_ver;
            ViewData["ex2"] = extra.timezone;

            ViewData["plg1"] = plugin.name;
            ViewData["plg2"] = plugin.version;

            return View();
        }
    }
}
