using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        // i would like to nest this in a while loop so the user is prompted again to input the numbers in case of an error.. but that is out of the scope of this exercise
        try
        {
            List<int> myNumbers = new List<int> { 0, 5, 23, 45, 67, 100, 780, 654700, 456712000 };
            Console.WriteLine("This program divides your number multiple times and prints the quotient. Please enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            foreach (int num in myNumbers)
            {
                int quotient = num / userNumber;
                Console.WriteLine(quotient);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number on the number pad.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You may not divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("We have completed the try/catch block. Well done thou good and faithful programmer.");
            Console.ReadLine();
        }
        }
    }

