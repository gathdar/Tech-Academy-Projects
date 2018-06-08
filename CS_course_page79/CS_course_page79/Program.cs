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
                LastName = "Marshall"
                Things = {"hello", "my", "name", "is", "george"}
            };



            //employee.Things.Add("hello");
            //employee.Things.Add("my");
            //employee.Things.Add("name");
            //employee.Things.Add("is");
            //employee.Things.Add("george");
            // employee.Things = new List<string>();

            //Employee<int> employee1 = new Employee<int>();
            //{
            //    //FirstName = "Mike",
            //    //LastName = "Jones",
            //    Things = { 1, 2, 3, 4, 5 }
            //};

            //Console.WriteLine(employee.FirstName);
            //Console.WriteLine(employee1.FirstName);

            //foreach (string i in employee)
            //    Console.WriteLine(employee[i]);

            //for (int i = 0; i < employee.Count; i++)
            //{
            //    Console.WriteLine(employee[i]);
            //}

            Console.WriteLine(string.Join(" ", employee));

            Console.ReadLine();
        }
    }
}
