using System;

namespace calculatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*converting a string to a number Convert.ToInt32()
            int num = Convert.ToInt32("45");   Console.ReadLine only returns strings*/

            Console.Write("Enter a Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);









            Console.ReadLine();


        }
    }
}
