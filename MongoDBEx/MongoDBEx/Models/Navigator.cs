using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginTest.Models
{
    [BsonIgnoreExtraElements]
    public class Navigator
    {
        public string appCodeName { get; set; }
        public string app_Name { get; set; }
        public string appversion { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
        public string oscpu { get; set; }
        public string vendor { get; set; }
        public string product { get; set; }
        public string securityPolicy { get; set; }
        public string userAgent { get; set; }
        public bool cookieEnabled { get; set; }
        public bool onLine { get; set; }
        public string build_ID { get; set; }
    }
}
