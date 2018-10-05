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
    class Algorithms
    {
        public int OddTotal(int[] inputArray)
        {
            int oddTotal = 0;
            foreach (int num in inputArray)
            {
                if (num % 2 != 0)
                {
                    oddTotal++;
                }
            }
            return oddTotal;
        }

        public int ArraySum (int[] inputArray)
        {
            int sum = 0;
            foreach (int num in inputArray)
            {
                sum += num;
            }
            return sum;
        }

        public string ReverseString (string inputString)
        {
            char[] letterArray = inputString.ToCharArray();
            int totalLength = letterArray.Length;
            char[] newArray = new char[totalLength];
            int backcount = totalLength - 1;

            for(int i = 0; i < totalLength; i++)
            {
                newArray[backcount] = letterArray[i];
                backcount--;
            }
            string reversedString = string.Join("", newArray);
            return reversedString;
        }

        public string RemoveRepeats(string inputString)
        {
            // I would clarify before starting whether capital and lowercase versions count as the same letter.
            // In this implementation I will treat them differently
            // I will also keep it simple and remove repeats of numbers and symbols

            char[] originalArray = inputString.ToCharArray();
            char[] newArray = new char[originalArray.Length];
            int i;
            int count = 0;

            for(i = 0; i < originalArray.Length; i++)
            {
                if (!newArray.Contains(originalArray[i]))
                {
                    newArray[count] = originalArray[i];
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Array.Resize(ref newArray, count + 1);
            string duplicatesRemoved = string.Join("", newArray);
            return duplicatesRemoved;
        }
    }
}
