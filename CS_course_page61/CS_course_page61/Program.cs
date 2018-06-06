using System;

namespace CS_course_page61
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_operation three_part_operation = new Math_operation();
            Console.WriteLine("Greetings. Please enter two integers and I will do a mysterious operation on them.");
            Console.WriteLine("If you submit nothing for the second, it will default to 5.");
            Console.Write("The first: ");
            string input1 = Console.ReadLine();
            Console.Write("The second: ");
            string input2 = Console.ReadLine();
            int num1;
            int num2;

            bool firstWorks = int.TryParse(input1, out num1);
            bool secondWorks = int.TryParse(input2, out num2);

            if (!firstWorks)
            {
                Console.WriteLine("The first number is not optional. The program will not continue.");
                Console.ReadLine();
                Environment.Exit(-1);
            }

            int num3 = Math_operation.Operation(num1, num2=5);
            Console.WriteLine("The operation has produced: {0}", num3);
            Console.ReadLine();
        }
    }
}
