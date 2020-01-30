using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool worked = double.TryParse(input, out double a);

            while (worked == false)
            {
                Console.WriteLine("That is not a number, please enter a number: ");
                input = Console.ReadLine();
                worked = double.TryParse(input, out a);
            }
            Console.WriteLine("The number you picked was " + a);


            Console.Write("please enter a second number: ");
            input = Console.ReadLine();
            worked = double.TryParse(input, out double b);

            while (worked == false)
            {
                Console.WriteLine("That is not a number, please enter a second number: ");
                input = Console.ReadLine();
                worked = double.TryParse(input, out b);
            }
            Console.WriteLine("The number you picked was " + b);
        }
    }
}
