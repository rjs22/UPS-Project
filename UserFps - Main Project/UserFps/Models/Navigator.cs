using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserFps.Models
{
    public class Navigator
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public string AppCodeName { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string Language { get; set; }
        public string Platform { get; set; }
        public string Oscpu { get; set; }
        public string Vendor { get; set; }
        public string Product { get; set; }
        public string SecurityPolicy { get; set; }
        public string UserAgent { get; set; }
        public bool CookieEnabled { get; set; }
        public bool Online { get; set; }
        public string BuildID { get; set; }
    }
}
