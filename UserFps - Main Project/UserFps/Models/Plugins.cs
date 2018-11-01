using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserFps.Models
{
    public class Plugins
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public string VersionNumber { get; set; }
    }
}
