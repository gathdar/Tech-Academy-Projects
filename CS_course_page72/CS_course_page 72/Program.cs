using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // i've been trying to input values on the same line but am getting errors
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName(employee.firstName, employee.lastName);
        }
    }
}
