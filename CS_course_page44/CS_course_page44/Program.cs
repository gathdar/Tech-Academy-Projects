using System;

namespace CS_course_page44
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operations doIt = new Operations();

            Console.WriteLine("This program will perform some operations on a number you provide.\nPlease input an integer.");
            try
            {

                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Operations.Addition(number));
                Console.WriteLine(Operations.Squared(number));
                Console.WriteLine(Operations.Subtraction(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
