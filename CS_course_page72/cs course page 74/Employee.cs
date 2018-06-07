using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs_course_page_74
{
    //step 2 page 74
    class Employee : Person, IQuittable
    {
        override public void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Greetings, {0} {1}.", firstName, lastName);
        }

        public void Quit()
        {
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
