using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserFps.Models
{
    public class Screen
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public int AvailHeight { get; set; }
        public int AvailWidth { get; set; }
        public int ColorDepth { get; set; }
        public int Height { get; set; }
        public int PixelDepth { get; set; }
        public int Width { get; set; }
    }
}
