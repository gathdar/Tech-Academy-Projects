using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page104
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gotIt = false;
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: {0}", currentTime);
            while (gotIt == false)
            {
                Console.WriteLine("Please enter an integer.");
                bool isNumber = int.TryParse(Console.ReadLine(), out int hours);
                if (isNumber == true)
                {
                    gotIt = true;
                    TimeSpan future = new TimeSpan(hours, 0, 0);
                    Console.WriteLine("In " + hours + " hour(s) it will be {0}.", currentTime.Add(future));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I didn't understand your input. Try again.");
                    continue;
                }
            }
            
        }
    }
}
