using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataApi.Models
{
    public class Vendor
    {
        public int ID { get; set; }
        public string VendorName { get; set; }
        public string VendorCode { get; set; }
        public bool ServiceActive { get; set; }
    }
}
