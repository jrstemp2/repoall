using System;

namespace forloop_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;
            string input;
            string goAgain;
            int sum = 0;
            int avg = 0;

            do
            {
                Console.Write("Please enter a number: ");
                input = Console.ReadLine();
                i = int.Parse(input);
                counter++;
                Console.Write("Play Again: y/n");
                goAgain = Console.ReadLine();
                sum += i;
                avg = sum / counter;
            } while (goAgain == "y");
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: " + avg);

        }
    }
}

