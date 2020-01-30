using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a word: ");
            Console.Write("Word: ");
            string word1 = Console.ReadLine();

            int midpoint = word1.Length / 2;
            string first = word1.Substring(0, midpoint);
            string last = word1.Substring(midpoint);
            int count = 1;

            for (int i = 1; i < 100; i++)
            {
                count++;
                if (count % 2 == 0)
                {
                    word1 = word1.ToUpper();
                    first = first.ToUpper();
                    last = last.ToUpper();
                }
                else
                {
                    word1 = word1.ToLower();
                    first = first.ToLower();
                    last = last.ToLower();
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(word1);
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(first);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(last);
                }
                else
                {
                    Console.WriteLine(i);
                }


            }





        }
    }
}

