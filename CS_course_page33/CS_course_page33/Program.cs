using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // array of strings
        string[] sentence = new string[] { "The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog." };
        Console.WriteLine("I am thinking of a sentence. Select an index (starting at 0), and I will retrieve the corresponding word.");
        string input = Console.ReadLine();
        int inputNum = Convert.ToInt32(input);

        // notification if the user selects an index that doesn't exist
        // note: this if statement will not catch letters, symbols or decimals, it will only catch whole numbers outside of the array
        // i have not accounted for all boneheaded inputs
        if (inputNum < 0 || inputNum > 8)
        {
            Console.WriteLine("Keep within the bounds of the array next time.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("{0}\n", sentence[inputNum]);
        }

        // array of integers
        int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        Console.WriteLine("I have an array of ten prime numbers. Select an index (starting at 0), and I will retrieve the corresponding number.");
        string input1 = Console.ReadLine();
        int inputNum1 = Convert.ToInt32(input1);

        // notification if the user selects an index that doesn't exist
        if (inputNum < 0 || inputNum > 9)
        {
            Console.WriteLine("Keep within the bounds of the array next time.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("{0}\n", primeNumbers[inputNum1]);

        }

        // list of strings
        List<string> stringList = new List<string> { "Can", "anybody", "find", "me", "somebody", "to", "love?" };
        Console.WriteLine("I have a list of seven words. Select an index (starting at 0), and I will retrieve the corresponding word.");
        string input2 = Console.ReadLine();
        int inputNum2 = Convert.ToInt32(input2);
        if (inputNum < 0 || inputNum > 6)
        {
            Console.WriteLine("Keep within the bounds of the list next time.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("{0}", stringList[inputNum2]);
            Console.ReadLine();
        }
    }
}
