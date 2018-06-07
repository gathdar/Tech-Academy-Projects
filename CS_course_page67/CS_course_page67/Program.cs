using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page67
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 4
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //step 5
            employee.SayName();
            Console.ReadLine();

        }
    }
}
