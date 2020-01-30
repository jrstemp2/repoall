using System;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            double num1;
            double num2;
            double product;

            

            Console.WriteLine("Let's work on some more math");
            Console.Write("Please enter your first number: ");
            input1 = Console.ReadLine();
            num1 = double.Parse(input1);

            Console.Write("Please enter your second number: ");
            input2 = Console.ReadLine();
            num2 = double.Parse(input2);
            product = num1 * num2;

            Console.WriteLine("The Product is " + product);



        }
    }
}
