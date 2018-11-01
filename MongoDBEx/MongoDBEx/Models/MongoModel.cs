using MongoDB.Bson;
using System.Collections.Generic;

namespace LoginTest.Models
{
    public class MongoModel
    {
        public ObjectId _id { get; set; }
        public Navigator navigator { get;set;}
        public Plugins[] plugins { get; set; }
        public Screen screen { get; set; }
        public Extra extra { get; set; }
    }
    
}
