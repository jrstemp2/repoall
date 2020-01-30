using System;

namespace stempowskiLab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's work on squares and cubes!!");
            Console.WriteLine();
            string goAgain;
            int counter = 0;
            do
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                 
                while (num <= 0)
                {
                    Console.WriteLine("That is not a valid number.");
                    Console.Write("Please enter a number greater than or equal to 1: ");
                    input = Console.ReadLine();
                    num = int.Parse(input);
                }
            
                for (int i = 1; i <= num; i++)
                {
                    counter++;
                    Console.WriteLine(String.Format("{0, counter, 30}" , i));
                }
                Console.Write("\nWould you like to continue? (Yes/No)");
                goAgain = Console.ReadLine();
            } while (goAgain == "yes" || goAgain == "Yes");

            Console.WriteLine("Thank you for your time. Please press enter to exit the program.");
            Console.ReadLine();
        }
    }
}

