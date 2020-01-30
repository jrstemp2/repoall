using System;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
            {
                Console.Write("Enter a number: ");
                //int num = int.Parse(Console.ReadLine());
                bool success = int.TryParse(Console.ReadLine(), out int num);
                Console.WriteLine(success);
            }*/

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(j);
                }
                
                Console.WriteLine();

            }




        }
    }
}
