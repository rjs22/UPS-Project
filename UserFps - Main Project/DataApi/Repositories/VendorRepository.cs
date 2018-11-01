using DataApi.Interfaces;
using DataApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        // Dependency injection.
        private readonly ProjectDBContext _context; // DB context for project

        // Associating the DI to a global environment to be accessed by all methods
        public VendorRepository(ProjectDBContext context)
        {
            _context = context;
        }

        // Fetching all rows from the DB that are marked true to be formed into JSON objects
        public IEnumerable<Vendor> GetVendorJSON()
        {
            return _context.Vendor.Where(c => c.ServiceActive == true);
        }
    }
}
