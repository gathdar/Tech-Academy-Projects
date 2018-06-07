using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_course_page_74
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        public abstract void SayName(string firstName, string lastName);
    }
}
