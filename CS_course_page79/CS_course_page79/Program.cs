using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page79
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>()
            {
                FirstName = "George",
                LastName = "Marshall",
                // Things = {"hello", "my", "name", "is", "george"}
            };

            if (employee.Things == null) // this is irrelevant, see line 39, but it is important to know that it remains null if not instantiated separately
            {
                employee.Things = new List<string>();
            }

            employee.Things.Add("hello");
            employee.Things.Add("my");
            employee.Things.Add("name");
            employee.Things.Add("is");
            employee.Things.Add("george");
            // employee.Things = new List<string>(); i tried this earlier but placing it here was too late

            Employee<int> employee1 = new Employee<int>()
            {
                FirstName = "Mike",
                LastName = "Jones",
                //Things = { 1, 2, 3, 4, 5 }
                // this cannot be instantiated here because the list/property needs to be separately instantiated
            };
            employee1.Things = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee1.FirstName);

            foreach (int i in employee1.Things)
                Console.WriteLine(employee1.Things[i-1]);

            for (int i = 0; i < employee.Things.Count; i++)
            {
                Console.WriteLine(employee.Things[i]);
            }

            Console.ReadLine();
        }
    }
}
