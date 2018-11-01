using System.Net;
using DataApi.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DataApi.Controllers
{
    // Controller is created through the use of the repository pattern.
    // Implementing this pattern can help insulate the application from changes in the data store 
    // and can facilitate automated unit testing or test-driven development (TDD).
    [Produces("application/json")] // Ensures the production of a JSON Object
    [EnableCors("AllowThisOrigin")] // Points to CORS policy that this Controller is associated to located in the startup file
    public class DefaultController
    {
        // Dependency injection.
        private readonly IVendorRepository _vendorRepository; // Interface that sets the method formed in the repository

        // Associating the DI to a global environment to be accessed by all methods
        public DefaultController(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        // method is used to grab all vendor code that is marked true within the database
        [Route("api/Object")] // sets the path used to access the JSON return
        public IActionResult GetVendorJSON()
        {
            var results = new ObjectResult(_vendorRepository.GetVendorJSON())
            {
                StatusCode = (int)HttpStatusCode.OK
            };

            return results;
        }
    }
}