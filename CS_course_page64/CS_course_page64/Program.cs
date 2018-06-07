using System;

namespace CS_course_page64
{
    class Program
    {
        static void Main(string[] args)
        {
            // step 2
            Divide divide = new Divide();
            int num1 = 0;
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Please enter an integer.");
                string input = Console.ReadLine();
                success = int.TryParse(input, out num1);
            }

            // step 3
            divide.Half(num1, out int num2);
            Console.WriteLine("Your number divided by 2 is: {0}", num2);
            divide.DivideByThree(num1, out int num3, out string hello);
            Console.WriteLine("{0}. Your number divided by 3 is: {1}", hello, num3);
            double overload = divide.DivideByThree(num1);
            Console.WriteLine("A more precise version is: {0}", overload);

            double originalNumberAttempt = Static_multiply.Multiply(overload);
            Console.WriteLine("I have statically multiplied the final number by 3: {0}", originalNumberAttempt);

            Console.ReadLine();

        }
    }
}
