using System;

namespace CS_course_Page22
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiply by 50
            Console.WriteLine("I will take your number and multiply it by 50. Please enter a number: ");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);
            int total = inputNum * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total);
            //Console.Read();  having this line run in between the code snippets causes an error

            // add 25
            Console.WriteLine("I will now take another number and add 25 to it. Please enter a number: ");
            input = Console.ReadLine();
            inputNum = Convert.ToInt32(input);
            total = inputNum + 25;
            Console.WriteLine("Your number plus 25 is: " + total);
 

            // divide by 12.5
            Console.WriteLine("I will now take another number and divide it by 12.5. Please enter a number: ");
            input = Console.ReadLine();
            double inputDouble = Convert.ToDouble(input);
            double totalDouble = inputDouble / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + totalDouble);


            // greater than 50?
            Console.WriteLine("I will now take another number and check if it is greater than 50. Please enter a number: ");
            input = Console.ReadLine();
            inputNum = Convert.ToInt32(input);
            bool isGreater = inputNum > 50;
            string isTrue;
            if (isGreater == true)
            {
                isTrue = "is ";
            }
            else
            {
                isTrue = "is not ";
            }
            Console.WriteLine("Your number {0}greater than 50.", isTrue);


            // modulus 7
            Console.WriteLine("I will now take another number, divide it by 7 and produce the remainder. Please enter a number: ");
            input = Console.ReadLine();
            inputNum = Convert.ToInt32(input);
            total = inputNum % 7;
            Console.WriteLine("Your number modulus 7 is: " + total);


            // AND operator

            bool firstEvaluation = 3 > 2 && 5 > 4;
            Console.WriteLine(firstEvaluation);

            // OR operator
            bool secondEvalutaion = 3 > 2 || 5 > 4;
            Console.WriteLine(secondEvalutaion);

            // NOT operator
            bool thirdEvaluation = 2 + 2 != 4;
            Console.WriteLine(thirdEvaluation);
            Console.ReadLine();
        }
    }
}
