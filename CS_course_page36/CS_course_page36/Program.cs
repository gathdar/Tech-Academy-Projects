using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        // page 36 assignment 1
        // one-dimensional array of strings
        string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.WriteLine("Greetings. Please enter some text to be added to each element:");
        string input = Console.ReadLine();
        // here we will add the user's text to each string
        for (int i = 0; i < days.Length; i++)
        {
            days[i] = days[i] + input;
            Console.WriteLine(days[i]);
        }
        Console.ReadLine();

        // page 36 assignment 2, commented out

        //int badIdea = 10;
        //while (badIdea > 2)
        //{
        //    Console.WriteLine("Make it stop!");
        //}

        // page 36 assignment 3
        int goodIdea = 10;
        while (goodIdea >2)
        {
            Console.WriteLine("I will eventually stop.");
            goodIdea--;
        }
        Console.ReadLine();

        // page 36 assignment 4
        int candyBarsEaten = 0;
        while (candyBarsEaten < 5) {
            candyBarsEaten++;
            Console.WriteLine("Yum! {0} candy bar(s) eaten.", candyBarsEaten);
        }
        Console.WriteLine("That's enough candy bars for today.");
        Console.ReadLine();

        // page 36 assignment 5
        int money = 100;
        int lotteryTicketCost = 10;
        int lotteryTicketsPurchased = 0;
        while (money >=lotteryTicketCost) {
            lotteryTicketsPurchased++;
            money = money - lotteryTicketCost;
            Console.WriteLine("I have bought {0} lottery tickets and have spent {1:c}. I have {2:c} left.", lotteryTicketsPurchased, (lotteryTicketsPurchased * lotteryTicketCost), money);
        }

        // page 36 assignment 6
        string[] familyNames = new string[] { "Moore", "Sasnett", "Brown", "Jardine", "Chandler", "St. Onge" };
        Console.WriteLine("Please type the family name you would like to search for: ");
        string query = Console.ReadLine();
        int falseCount = 0;
        for (int i = 0; i < familyNames.Length; i++)
        {
            if (query == familyNames[i])
            {
                Console.WriteLine("The index number of the item you are looking for is {0}.", i);
                // page 36 assignment 8
                i = familyNames.Length;
            }
            else
            {
                falseCount++;
            }
            // page 36 assignment 7
            if (falseCount == familyNames.Length)
                Console.WriteLine("The name you entered is not in the database.");
        }
        Console.ReadLine();

        //page 36 assignment 9
        string[] teamPlayers = new string[] { "Jack", "Jill", "Brian", "Arthur", "Ruth", "Jack", "Bob", "Xavier", "Lance", "Ruth", "Amanda" };
        Console.WriteLine("Please enter the name of the team member you would like to search for: ");
        string query1 = Console.ReadLine();
        int falseCount1 = 0;
        for (int j = 0; j < teamPlayers.Length; j++)
        {
            if (query1 == teamPlayers[j])
            {
                Console.WriteLine("The name you searched for appears at the following index number: {0}.", j);
            }
            else
            {
                falseCount1++;
            }
            // page 36 assignment 10
            if (falseCount1 == teamPlayers.Length)
                Console.WriteLine("The name you entered is not in our database.");
        }
        Console.ReadLine();

        // page 36 assignment 11
        List<string> cities = new List<string>() {"Vancouver", "Rome", "New York", "Hartford", "Philadelphia", "Vancouver", "Berlin", "Rome"};
        List<string> alreadyIn = new List<string>();
        foreach (string city in cities) {
            Console.Write(city);
            if (alreadyIn.Contains(city))
            {
                Console.WriteLine(" (This city has already appeared in the list.)");
            }
            else
            {
                Console.WriteLine();
            }
            alreadyIn.Add(city);
        }
        Console.ReadLine();
        }
    }

