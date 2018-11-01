using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserFps.Models
{
    public class LoginRecord
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public string DeviceId { get; set; }
        public string Vendor1Return { get; set; }
        public string Vendor2Return { get; set; }
        public string Vendor3Return { get; set; }
        public string Vendor4Return { get; set; }
        public string Vendor5Return { get; set; }
        public string Vendor6Return { get; set; }

        public string TransactionSource { get; set; }
    }
}
