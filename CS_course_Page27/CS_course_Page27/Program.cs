using System;

class Program
    {
        static void Main()
        {
        Random rnd = new Random();
        int compNum = rnd.Next(1, 10);
        Console.WriteLine("I am thinking of a number between 1 and 10. \n Try and guess it.");
        string inputStr;
        int inputNum = 0;
        bool isGuessed = (inputNum == compNum);
        while (!isGuessed)
        {
            inputStr = Console.ReadLine();
            bool goodUser = int.TryParse(inputStr, out inputNum);
            if (goodUser)
            {
                if (inputNum > compNum)
                {
                    Console.WriteLine("My number is lower. Try again.");
                }
                else if (inputNum < compNum)
                {
                    Console.WriteLine("My number is higher. Try again.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Try again.");
            }

            
        }
        Console.WriteLine("Well done! The number was {0}.", compNum);
        Console.ReadLine();
        }
    }

