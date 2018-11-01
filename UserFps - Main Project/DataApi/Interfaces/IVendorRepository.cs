using DataApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Interfaces
{
    public interface IVendorRepository
    {
        // Setting method to grab DB data to be formed as JSON data.
        IEnumerable<Vendor> GetVendorJSON();
    }
}
