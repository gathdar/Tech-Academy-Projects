using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page82
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek daysofWeek = new DaysOfWeek();

            bool isCorrect = false;
            
            Console.WriteLine("Greetings. Please enter the current day of the week.");
            while (!isCorrect)
            {
                string input = Console.ReadLine();
                try
                {
                    DaysOfWeek.Days newDay = (DaysOfWeek.Days)Enum.Parse(typeof(DaysOfWeek.Days), input);
                    Console.WriteLine("Today is {0}", newDay);
                    isCorrect = true;
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            

        }
    }
}
