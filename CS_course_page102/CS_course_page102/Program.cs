using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_course_page102
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Greetings. Please enter a number.");
                bool isNumber = double.TryParse(Console.ReadLine(), out double input);
                if (isNumber)
                {
                    using (StreamWriter file = new StreamWriter(@"C:\Users\SirJUST\Logs\numberlog.txt", true))
                    {
                        file.WriteLine(input);
                    }
                }
                else
                {
                    Console.WriteLine("I didn't recognize your format. Please try again.");
                    continue;
                }
                Console.WriteLine("The last entry was: {0}", input);
                string totalFile = File.ReadAllText("C:\\Users\\SirJUST\\Logs\\numberlog.txt");
                Console.WriteLine("Here is the file in its entirety:\n{0}", totalFile);
                finished = true;
                Console.ReadLine();
            }
            
        }
    }
}
