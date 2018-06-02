using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// tried to do an enum here but i couldn't get the value of the items

    class Program
    {
        static void Main(string[] args)
        {
            string[] seasons = new string[] { "spring", "summer", "fall", "winter" };
            Console.WriteLine("Can you guess my favorite season? (use 'fall' instead of autumn please)");
            string input = "";
            bool isGuessed = input == seasons[1];

            do
            {
                input = Console.ReadLine().ToLower();
                switch (input) { 
                    case "spring": Console.WriteLine("Nope. Try again.");
                        break;
                    case "summer": Console.WriteLine("That's right!");
                        isGuessed = true;
                        Console.Read();
                        break;
                    case "fall": Console.WriteLine("Nope. Try again.");
                        break;
                    case "winter": Console.WriteLine("Nope. Try again.");
                        break;
                    default: Console.WriteLine("Do you even spell bro?");
                        break;
                }
            }
            while (!isGuessed);

        }
    }
