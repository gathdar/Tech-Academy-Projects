using System;

class Program
    {
        static void Main()
        {
        // this program uses some Groundhog Day quotes to practice comparisons and the ternary operator
            Console.WriteLine("Do you have life insurance? Y/N");
            string input = Console.ReadLine().ToUpper();

            if (input == "Y")
            {
                Console.WriteLine("Well if you do you could always use a little more! \nAmIrightoramIrightoramIright?");
            }
            else if (input == "N")
            {
                Console.WriteLine("I got's a feelin'... /whistle... you ain't got any.");
            }
            else
            {
                Console.WriteLine("Watch out for that first step it's a doozy!");
            }

            Console.WriteLine("Would you like some great life insurance? Y/N");
            string input1 = Console.ReadLine().ToUpper() == "Y" ? "This is the best day of my life!" : "Come on old buddy Case Western High!";
        Console.WriteLine(input1);
        Console.Read();
        }
    }
