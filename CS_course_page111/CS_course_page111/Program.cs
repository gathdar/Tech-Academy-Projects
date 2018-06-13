using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page111
{
    class Program
    {
        static void Main(string[] args)
        {
            const string cannotChange = "A constant cannot change, be set to a value that could change,\nor use an implicitly typed variable.";
            Console.WriteLine(cannotChange);
            var bicycle = new Bicycle("Speedy");
            Bicycle bicycle1 = new Bicycle("Slowpoke", 3, "small", 2, "orange");
            Console.WriteLine("{0} has fewer wheels ({1}) than {2} which has {3}.\nThe reason is because of my constructor call chain.", bicycle.Name, bicycle.Wheels, bicycle1.Name, bicycle1.Wheels);
            Console.ReadLine();
        }
    }
}
