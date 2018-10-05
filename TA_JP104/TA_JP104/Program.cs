using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given an array of integers, write a method to total the odd numbers.
// Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
// Given a string, reverse it.
// Given a string, remove any repeated letters.

namespace TA_JP104
{
    class Program
    {
        static void Main()
        {
            Algorithms algorithms = new Algorithms();

            int[] testArray = new int[8] {1, 2, 3, 4, 5, 0, 100, 365 };
            string testString = "Hello world, my name is Justin.";

            Console.WriteLine(algorithms.OddTotal(testArray));
            Console.WriteLine(algorithms.ArraySum(testArray));
            Console.WriteLine(algorithms.ReverseString(testString));
            Console.WriteLine(algorithms.RemoveRepeats(testString));
            Console.Read();
        }
    }
}
