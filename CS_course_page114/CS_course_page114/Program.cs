using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page114
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            int age = 0;
            while(!validInput)
            {
                // step 1
            Console.WriteLine("Hello. Please input your age.");
                // step 3
                try
                {
                    age = int.Parse(Console.ReadLine());
                    if (age == 0)
                    {
                        throw new ZeroException();
                    }
                    else if (age < 0)
                {
                    throw new NegativeException();
                }
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter your age in digits.");
                    continue;
                }
                catch (ZeroException)
                {
                    //step 4
                    Console.WriteLine("No one zero years old can find zero on the keyboard!");
                    continue;
                }
                catch (NegativeException)
                {
                    //step 4
                    Console.WriteLine("No one is negative years old. Please try again.");
                    continue;
                }
                catch (Exception)
                {
                    //step 5
                    Console.WriteLine("Something went wrong. Please try again.");
                    continue;
                }
            }

            DateTime BirthTime = DateTime.Now.AddYears(-(age +1));
            int BirthYear = BirthTime.Year;
            // step 2
            Console.WriteLine("Your birth year is likely: {0}", BirthYear);
            Console.ReadLine();
        }
    }
}
