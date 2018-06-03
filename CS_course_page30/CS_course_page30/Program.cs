using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am " + "concatenating " + "many " + "strings together." + "    :)\n");
            string one = "Another ";
            string two = "way ";
            string three = "to concatenate ";
            string four = "is like this.\n";

            Console.WriteLine(one + two + three + four);

            Console.WriteLine("We could also do the following: {0}{1}{2}{3}", one, two, three, four);

            string hello = "hello\n";
            string loud = hello.ToUpper();
            Console.WriteLine(loud);

            StringBuilder para = new StringBuilder();
            para.Append("My two brothers, two cousins and myself are planning a grand adventure at the end of June. ");
            para.Append("My oldest cousin bought a sailboat, and we are going to sail down a river somewhere in the Cascades. ");
            para.Append("When we were children we would explore the forests nearby for hours on end, so we are all excited about doing so again. ");
            para.Append("My only concern is this: ");
            para.Append("Will I still be able to practice my coding during this journey? ");
            para.Append("We shall see.");

            Console.WriteLine(para);
            Console.Read();
        }
    }
}
