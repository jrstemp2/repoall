using System;

namespace CodeChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            bool worked = int.TryParse(input, out int num);

            while (worked == false || num <= 0)
            {
                Console.WriteLine("That is not a valid number.");
                Console.Write("Please enter a number that is greater than 0: ");
                input = Console.ReadLine();
                worked = int.TryParse(input, out num);
            }
           
            for (int i = num; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
