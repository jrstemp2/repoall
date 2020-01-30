using System;

namespace forloop_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int y = 0;
            int sum = 0;
            int avg = 0;

            for (i = 1; i<= 5; i++)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                y = int.Parse(input);
                sum += y;
                avg = sum / 5;
            }
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("THe Average is: " + avg);
        }
    }
}
