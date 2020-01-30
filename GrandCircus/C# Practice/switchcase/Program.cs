using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number between 1 and 4: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                case 4:
                    Console.WriteLine("four");
                    break;

                default:
                    Console.WriteLine("Thats not right");
                    break;
            }





        }
    }
}
