using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page111
{
    class Bicycle
    {
        public Bicycle(string name) : this(name, 2, "unknown", 5, "unknown")
        {

        }
        public Bicycle(string name, int wheels, string size, int speeds, string color)
        {
            Name = name;
            Wheels = wheels;
            Size = size;
            Speeds = speeds;
            Color = color;
        }

        public string Name { get; set; }
        public int Wheels { get; set; }
        public string Size { get; set; }
        public int Speeds { get; set; }
        public string Color { get; set; }

    }
}
