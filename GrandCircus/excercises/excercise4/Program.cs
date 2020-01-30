using System;

namespace excercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Let's work on some math problems!");
            Console.Write("Please enter your first number: ");
            string input1 = Console.ReadLine();
            double num1 = double.Parse(input1);

            Console.Write("Please enter your second number: ");
            string input2 = Console.ReadLine();
            double num2 = double.Parse(input2);

            double sum = num1 + num2;

            Console.WriteLine("The Sum is " + sum);

        }
    }
}
