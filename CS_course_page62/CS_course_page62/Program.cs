using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page62
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 2, instantiate the class
            Fun_W_Integers hello = new Fun_W_Integers();
            bool success1 = false;
            bool success2 = false;
            int num1 = 0;
            int num2 = 0;
            // here i wanted to keep giving options to input correctly
            while (!success1 || !success2)
            {
                Console.WriteLine("Please enter two integers.");
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                success1 = int.TryParse(input1, out num1);
                success2 = int.TryParse(input2, out num2);
            }

            // step 3 call the method of the class
            hello.Operation(num1, num2);
            // step 4 call the method but specify the parameters by name
            hello.Operation(num1: num1, num2: num2);
 

           
        }
    }
}
