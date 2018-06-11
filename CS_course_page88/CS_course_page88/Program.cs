using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page88
{
    struct Employee
    {
        public string firstName;
        public string lastName;
        public int idNumber;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //step 1
            List<Employee> employees = new List<Employee>()
            {
                new Employee { firstName = "Joe", lastName = "Williams", idNumber = 0 },
                new Employee { firstName = "Sarah", lastName = "Banks", idNumber = 1},
                new Employee { firstName = "Matt", lastName = "Dennison", idNumber = 2},
                new Employee { firstName = "Emily", lastName = "Jefferson", idNumber = 3},
                new Employee { firstName = "Brett", lastName = "Davis", idNumber = 4},
                new Employee { firstName = "Jason", lastName = "Lord", idNumber = 5},
                new Employee { firstName = "Joe", lastName = "White", idNumber = 6},
                new Employee { firstName = "Susan", lastName = "Miller", idNumber = 7},
                new Employee { firstName = "Mandy", lastName = "Cook", idNumber = 8},
                new Employee { firstName = "Bart", lastName = "Jenson", idNumber = 9},
            };

            // step 2
            List<Employee> namedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    namedJoe.Add(employee);
                }
            }
            // this will check to see that these entries were added to the new list
            foreach (Employee employee in namedJoe)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.ReadLine();

            //step 3
            List<Employee> namedJoeLD = new List<Employee>();
            namedJoeLD = employees.Where(x => x.firstName == "Joe").ToList();
            // this will check the list made with a lambda function
            foreach (Employee employee in namedJoeLD)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.ReadLine();

            List<Employee> overFive = new List<Employee>();
            overFive = employees.Where(x => x.idNumber > 5).ToList();
            foreach (Employee employee in overFive)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.ReadLine();
        }
    }
}
