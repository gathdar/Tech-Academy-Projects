using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page62
{
    // step 1, create the class with a void method
    class Fun_W_Integers
    {
        public void Operation (int num1, int num2)
        {
            double num3 = Math.Exp(num1) / Math.Log(num1);

            Console.WriteLine("The result of my operation on your first number is: {0}", num3);
            Console.WriteLine("The second number you typed is {0}", num2);
            Console.ReadLine();
        }
    }
}
