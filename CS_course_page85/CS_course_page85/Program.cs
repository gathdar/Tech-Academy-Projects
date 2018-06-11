using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page85
{
    struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 35.55m };

            Console.WriteLine("Your amount is: {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
