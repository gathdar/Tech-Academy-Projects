using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page_72
{
    // another word for abstract class is base class
    public abstract class Person
    {
        //step 1
        public string firstName;
        public string lastName;

        //step 2
        public abstract void SayName(string firstName, string lastName);
    }
}
