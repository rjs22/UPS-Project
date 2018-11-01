using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using UserFps.Models;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using UserFps.Classes;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;

namespace UserFps.Controllers
{
    public class UsersModelController : Controller
    {
        // Dependency injection.
        private readonly UserContext _context; // DB context for project
        private readonly IOptions<ConnectionStrings> _connectionStrings; //connection string used to call stored procedure

        // Associating the DI to a global environment to be accessed by all methods
        public UsersModelController(UserContext context,
                                    IOptions<ConnectionStrings> connectionStrings)
        {
            _context = context;
            _connectionStrings = connectionStrings;
        }

        // GET: UsersModel/Register
        public IActionResult Register()
        {

            return View();
        }

        // POST: UsersModel/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UsersModel account)
        {
            if (ModelState.IsValid)
            {
                //Adds user information to db including the DeviceId thats generated from device they register with
                
                _context.Add(account);
                account.CreatedDate = DateTime.Now;
                account.TransactionSource = "IDC";  //At registration, the user creates an ID
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login)); //user directed to Login after registration
            }
            return View();
        }
        // GET: UsersModel/Login
        public IActionResult Login()
        {
            return View();
        }

        //POST: UsersModel/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UsersModel usersModel)
        {
            // Vendor return from JS area
            // Grabbing encrypted string from client
            var vendor = Request.Form["ioBlackBox"].ToString();

            // Decrypting string
            var keybytes = Encoding.UTF8.GetBytes("7061737323313233");
            var iv = Encoding.UTF8.GetBytes("7061737323313233");
            var encrypted = Convert.FromBase64String(vendor);
            var decriptedVendorObj = Encrypter.DecryptStringFromBytes(encrypted, keybytes, iv);

            // Creating JSON object in a C# format from returned string
            JObject vendorObj = JObject.Parse(decriptedVendorObj);

            //Instantiate strings and ints to be used for database submissions
            string ven1, ven2, ven3, ven4, ven5;
            string appCode, appName, appVer, lang, plat, oscpu, vend, prod, sec, usrA, bld;
            bool cook, onln;
            string pluginName1, pluginVersion1, pluginName2, pluginVersion2, pluginName3, pluginVersion3, pluginName4, pluginVersion4, pluginName5, pluginVersion5;
            int availHeight, availWidth, colorDepth, height, pixelDepth, width;
            string javascriptVer; int timezone;

            // In this section, The code is separating the JSON object into separate JToken collections to be iterated though are parsed out
            // to be added into its respective DB columns.
            // The Conditional group is to ensure object instances have something in them. Will throw a ArgumentNullException if JToken object is empty
            // If they are empty, all values are set to either null or 0 
            if (_context.Vendor.Where(v => v.VendorName.Equals("ioaa") && v.ServiceActive == true).Any())
            {
                // Each instantiation of the JToken class uses the SelectToken method to find the specific value pertaining 
                // to the desired element it needs to bring back. The SelectToken method takes in a JSONPath argument as a parameter.
                // much like XPath for XML, this is used to iterate through the entire JSON return.
                // For more help, go to http://goessner.net/articles/JsonPath/index.html and http://jsonpath.com/
                IEnumerable<JToken> ioaa = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioaa')]");
                
                // Each collection is iterated though using the "ElementAt" method to take the value and attach it to the global variable
                // The global variable is then used for the submission of the data into the DB.
                ven1 = (string)ioaa.ElementAt(1);
            }
            else
                ven1 = null;
            // Iobb call returns a string
            if (_context.Vendor.Where(v => v.VendorName.Equals("iobb") && v.ServiceActive == true).Any())
            {
                IEnumerable<JToken> iobb = vendorObj.SelectToken("$.Vendors[?(@.Key == 'iobb')]");
                ven2 = (string)iobb.ElementAt(1);
            }
            else
                ven2 = null;
            // Iocc call returns a string
            if (_context.Vendor.Where(v => v.VendorName.Equals("iocc") && v.ServiceActive == true).Any())
            {
                IEnumerable<JToken> iocc = vendorObj.SelectToken("$.Vendors[?(@.Key == 'iocc')]");
                ven3 = (string)iocc.ElementAt(1);
            }
            else
                ven3 = null;
            // Iodd call returns a string
            if (_context.Vendor.Where(v => v.VendorName.Equals("iodd") && v.ServiceActive == true).Any())
            {
                IEnumerable<JToken> iodd = vendorObj.SelectToken("$.Vendors[?(@.Key == 'iodd')]");
                ven4 = (string)iodd.ElementAt(1);
            }
            else
                ven4 = null;
            // Ioee call returns a string
            if (_context.Vendor.Where(v => v.VendorName.Equals("ioee") && v.ServiceActive == true).Any())
            {
                IEnumerable<JToken> ioee = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioee')]");
                ven5 = (string)ioee.ElementAt(1);
            }
            else
                ven5 = null;
            // Ioff call. This returns another JSON object. The code parses though the whole object and adds it to the DB.
            // The DB is separated in to multiple tables pertaining to the section of the JSON object and the values are are added to their
            // respective columns. Column names are based off the key names used in the JSON object
            if (_context.Vendor.Where(v => v.VendorName.Equals("ioff") && v.ServiceActive == true).Any())
            {
                // Grabbing Navigator section of Extended Vendor JSON Object
                IEnumerable<JToken> navigator = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.navigator");
                appCode = (string)navigator.ElementAt(0);
                appName = (string)navigator.ElementAt(1);
                appVer = (string)navigator.ElementAt(2);
                lang = (string)navigator.ElementAt(3);
                plat = (string)navigator.ElementAt(4);
                oscpu = (string)navigator.ElementAt(5);
                vend = (string)navigator.ElementAt(6);
                prod = (string)navigator.ElementAt(7);
                sec = (string)navigator.ElementAt(8);
                usrA = (string)navigator.ElementAt(9);
                cook = (bool)navigator.ElementAt(10);
                onln = (bool)navigator.ElementAt(11);
                bld = (string)navigator.ElementAt(12);

                // Grabbing Plugin section of Extended Vendor JSON Object. Plugins are a nested array of nested objects.
                // For simplification, once the user has logged in, all "Names" from objects are added in one column
                // and all "Versions" are added into the other column. 
                IEnumerable<JToken> firstPlugin = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.plugins[0]");
                pluginName1 = (string)firstPlugin.ElementAt(0);
                pluginVersion1 = (string)firstPlugin.ElementAt(1);
                IEnumerable<JToken> secondPlugin = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.plugins[1]");
                pluginName2 = (string)secondPlugin.ElementAt(0);
                pluginVersion2 = (string)secondPlugin.ElementAt(1);
                IEnumerable<JToken> thirdPlugin = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.plugins[2]");
                pluginName3 = (string)thirdPlugin.ElementAt(0);
                pluginVersion3 = (string)thirdPlugin.ElementAt(1);
                IEnumerable<JToken> fourthPlugin = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.plugins[3]");
                pluginName4 = (string)fourthPlugin.ElementAt(0);
                pluginVersion4 = (string)fourthPlugin.ElementAt(1);
                IEnumerable<JToken> fifthPlugin = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.plugins[4]");
                pluginName5 = (string)fifthPlugin.ElementAt(0);
                pluginVersion5 = (string)fifthPlugin.ElementAt(1);

                // Grabbing Screen section of Extended Vendor JSON Object
                IEnumerable<JToken> screen = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.screen");
                availHeight = (int)screen.ElementAt(0);
                availWidth = (int)screen.ElementAt(1);
                colorDepth = (int)screen.ElementAt(2);
                height = (int)screen.ElementAt(3);
                pixelDepth = (int)screen.ElementAt(4);
                width = (int)screen.ElementAt(5);

                // Grabbing Extra section of Extended Vendor JSON Object
                IEnumerable<JToken> extra = vendorObj.SelectToken("$.Vendors[?(@.Key == 'ioff')].Data.extra");
                javascriptVer = (string)extra.ElementAt(0);
                timezone = (int)extra.ElementAt(1);
            }
            else
            {
                appCode = null; appName = null; appVer = null; lang = null; plat = null; oscpu = null; vend = null; prod = null;
                sec = null; usrA = null; cook = false; onln = false; bld = null;

                pluginName1 = null; pluginVersion1 = null; pluginName2 = null; pluginVersion2 = null; pluginName3 = null; pluginVersion3 = null;
                pluginName4 = null; pluginVersion4 = null; pluginName5 = null; pluginVersion5 = null;

                availHeight = 0; availWidth = 0; colorDepth = 0; height = 0; pixelDepth = 0; width = 0;

                javascriptVer = null; timezone = 0;
            }

            //Start of procedure call to check Device
            //Calls the stored procedure [usersInfo] that has username and device ID as the parameters
            //User input has to match with procedure parameters in the db to allow user to login
            SqlConnection conn = new SqlConnection(_connectionStrings.Value.FPSProjContextConnection);
            SqlCommand cmd = new SqlCommand("User_Device_Match", conn) //usersInfo is name of stored procedure
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlParameter parameter = new SqlParameter("@UserName", usersModel.UserName);
            SqlParameter parameter2 = new SqlParameter("@Device", usersModel.DeviceId); //DeviceId captured from client-js 
            cmd.Parameters.Add(parameter);
            cmd.Parameters.Add(parameter2);
            //end of procedure call

            //Authentication: Variable "account" returns not null if it finds username input (u.UserName) and password input (u.Password) 
            //in the UsersModel database. Returns null if no match is found.
            var account = _context.UsersModel.Where(u => u.UserName == usersModel.UserName && u.Password == usersModel.Password).FirstOrDefault();

            //result is the query outcome of the stored procedure
            //Will change to 0 if device match or 1 if there's no device match
            int result = -1;

            try
            {
                conn.Open();
                result = (int)cmd.ExecuteScalar(); //Executes the store procedure call as an int
            }
            catch (Exception){ }
            finally
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Close();
            }
            if (account != null) //if user exists
            {
                if (result == 0) //if device ID at login matches with device ID in db
                {
                    HttpContext.Session.SetString("UserName", account.UserName.ToString()); //user sign in
                    
                    // DB submisison section
                    // This section is taking all the global variables and adding their values in to the DB.
                    // LoginRecord: Saving all that is returned from the first five vendors which are single strings.
                    var user = new LoginRecord
                    {
                        UserName = usersModel.UserName,
                        DateTime = DateTime.Now,
                        DeviceId = usersModel.DeviceId,
                        Vendor1Return = ven1,
                        Vendor2Return = ven2,
                        Vendor3Return = ven3,
                        Vendor4Return = ven4,
                        Vendor5Return = ven5,
                        TransactionSource = "LGN" ///transaction code every time a user logs in
                    };
                    _context.LoginRecord.Add(user);
                    _context.SaveChanges();

                    // Saving all context that is within the 6th vendor which holds multipule objects and values.
                    // User name and date are also stored along with the submission to ensure the data is connected to a user.
                    // Saving Navigator object
                    var navObj = new Navigator
                    {
                        UserName = usersModel.UserName,
                        DateTime = DateTime.Now,
                        AppCodeName = appCode,
                        AppName = appName,
                        AppVersion = appVer,
                        Language = lang,
                        Platform = plat,
                        Oscpu = oscpu,
                        Vendor = vend,
                        Product = prod,
                        SecurityPolicy = sec,
                        UserAgent = usrA,
                        CookieEnabled = cook,
                        Online = onln,
                        BuildID = bld
                    };
                    _context.Navigator.Add(navObj);
                    _context.SaveChanges();

                    // Saving Plugin Object
                    var plugObj = new Plugins
                    {
                        UserName = usersModel.UserName,
                        DateTime = DateTime.Now,
                        Name = "First Obj: " + pluginName1 + ", Second Obj: " + pluginName2 + ", Third Obj: " + pluginName3 + ", Fourth Obj: " + pluginName4 + ", Fifth Obj: " + pluginName5,
                        VersionNumber = "First Obj: " + pluginVersion1 + ", Second Obj: " + pluginVersion2 + ", Third Obj: " + pluginVersion3 + ", Fourth Obj: " + pluginVersion4 + ", Fifth Obj: " + pluginVersion5
                    };
                    _context.Plugins.Add(plugObj);
                    _context.SaveChanges();

                    // Saving Screen Object
                    var scrnObj = new Screen
                    {
                        UserName = usersModel.UserName,
                        DateTime = DateTime.Now,
                        AvailHeight = availHeight,
                        AvailWidth = availWidth,
                        ColorDepth = colorDepth,
                        Height = height,
                        PixelDepth = pixelDepth,
                        Width = width
                    };
                    _context.Screen.Add(scrnObj);
                    _context.SaveChanges();

                    // Saving Extra Object
                    var extObj = new Extra
                    {
                        UserName = usersModel.UserName,
                        DateTime = DateTime.Now,
                        JavascriptVer = javascriptVer,
                        Timezone = timezone
                    };
                    _context.Extra.Add(extObj);
                    _context.SaveChanges();

                    //User returns to landing page
                    return RedirectToAction(nameof(LoggedIn));

                }
                //Authentication of user credentials passed, but did not recognize the device to device on database
                else
                {
                    ModelState.AddModelError("", "Unable to verify. Please call 1-800-123-4567.");
                }
            }
            //Authentication failed
            else
            {
                ModelState.AddModelError("", "Invalid Login");

            }
            return View();
        }

        //GET: UsersModel/LoggedIn
        public ActionResult LoggedIn()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                ModelState.AddModelError("", "You must be logged in");
                return RedirectToAction("Login");
            }
        }

        //GET: UsersModel/Logout
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}