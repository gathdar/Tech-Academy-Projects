using System;

namespace CS_course_page57
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication operation = new Multiplication();
            int operand = 3;
            int answer = Multiplication.Multiplier(operand);
            Console.WriteLine("The answer is: {0}", answer);
            Console.ReadLine();

            decimal myNumber = 345.345678m;
            decimal newAnswer = Multiplication.NewMultiplier(myNumber);
            Console.WriteLine("The new answer is: {0}", newAnswer);
            Console.ReadLine();

            string reallyANumber = "345";
            int result = Multiplication.Converter(reallyANumber);
            Console.WriteLine("The newest answer is: {0}", result);
            Console.ReadLine();
        }
    }
}
