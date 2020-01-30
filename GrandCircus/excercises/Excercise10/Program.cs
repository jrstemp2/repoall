using System;

namespace Excercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            const double REQUIRED = 54;
            string goAgain ="y";

            while (goAgain == "y") 
            {
                Console.Write("Please enter your Height in inches: ");
                double height = double.Parse(Console.ReadLine());
                double diff = REQUIRED - height;


                if (height < REQUIRED)
                {
                    Console.WriteLine("Sorry, you cannot ride the Raptor. You need " + diff + " more inches");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }
                Console.Write("Do you want to continue (y/n): ");
                goAgain = Console.ReadLine();
            } 
            Console.WriteLine("Goodbye!");
            

        }
    }
}
