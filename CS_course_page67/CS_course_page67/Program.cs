using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page77
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {FirstName = "John", LastName = "White", Id = 1000},
                new Employee {FirstName = "Max", LastName = "Ford", Id = 1001},
                new Employee {FirstName = "Beth", LastName = "Carmichael", Id = 1002},
                new Employee {FirstName = "Steve", LastName = "Johnson", Id = 1003}
            };

            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            foreach(Employee employee in employees)
            {
                employee.SayName();
                Console.WriteLine("Id: " + employee.Id);
            }


            bool isSame = employees[0] == employees[1];
            if (!isSame)
            {
                Console.WriteLine(employees[0].FirstName + " " +employees[0].LastName + " has a different Id than " + employees[1].FirstName + " " + employees[1].LastName + ".");
            }
            else
            {
                Console.WriteLine(employees[0].FirstName + " " + employees[0].LastName + " has the same Id as " + employees[1].FirstName + " " + employees[1].LastName + ".");
            }
            Console.ReadLine();

        }
    }
}
