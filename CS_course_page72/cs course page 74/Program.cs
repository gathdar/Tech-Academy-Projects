using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs_course_page_74
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName(employee.firstName, employee.lastName);

            //step 3 page 74
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
