using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page57
{
    class Multiplication
    {
        public static int Multiplier(int operand)
        {
            int newNumber = operand * 10;
            return newNumber;
        }

        public static decimal NewMultiplier(decimal myNumber)
        {
            decimal newNumber = myNumber * myNumber;
            return newNumber;
        }

        public static int Converter(string myString)
        {
            bool works = int.TryParse(myString, out int convertedString);
            int newConvertedString = convertedString * 3;
            return newConvertedString;
        }
    }
}
