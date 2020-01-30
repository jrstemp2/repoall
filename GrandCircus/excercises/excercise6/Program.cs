using System;

namespace excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain;

            do
            {
                Console.WriteLine("Hello World!");
                Console.Write("Would you like to continue (y/n)");
                goAgain = Console.ReadLine();
            } while (goAgain == "y");
            Console.WriteLine("Goodbye!");
            

        }
    }
}
