using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 0; i <= 100; i++)  // int i is initialize, i <= 100 is the condition and i++ is incrementing
            {
                Console.WriteLine(i);
            }*/

            /*for (int i = 2; i <= 100; i+=2)  // int i is initialize, i <= 100 is the condition and i+=2 is incrementing by 2s
            {
                Console.WriteLine(i);
            }*/

            //Count from 50 down to 1
            /*for (int i = 50; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/

            //Count from 5 to 100 by 5s
            /*for(int i = 5; i <= 100; i+=5)
            {
                Console.WriteLine(i);
            }*/

            //count powers of 2 from 2 to 4096
            /*for (int i = 2; i <= 4096; i *= 2)
            {
                Console.WriteLine(i);
            }*/
            
            
            //count from 100 to -100 by 10s
            /*for (int i = 100; i >= -100; i -= 10)
            {
                Console.WriteLine(i);
            }*/

            //output the prime factors of each number 1-100. do not use else if sine this there is multiple true options. 
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"Factors of {i}: ");
                if (i % 2 == 0)
                {
                    Console.Write(2 + " ");
                }
                if (i % 3 == 0)
                {
                    Console.Write(3 + " ");
                }
                if (i % 5 == 0)
                {
                    Console.Write(5 + " ");
                }
                if (i % 7 == 0)
                {
                    Console.Write(7 + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
