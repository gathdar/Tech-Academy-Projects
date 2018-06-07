using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page_72
{
    // step 3
    class Employee : Person
    {
        override public void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Greetings, {0} {1}.", firstName, lastName);
            Console.ReadLine();
        }
    }
}
