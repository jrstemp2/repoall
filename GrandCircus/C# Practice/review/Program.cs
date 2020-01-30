using System;

namespace review
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    //Code runs normally in try
                    Console.WriteLine("input an int");
                    int num = int.Parse(Console.ReadLine());

                }

                //This is where the error is caught and an exception is made to keep moving.
                catch (FormatException e)
                {
                    Console.WriteLine("Incorrect Format");

                }
                finally
                {
                    Console.WriteLine("Move On");
                }

            }

        }
    }
}
