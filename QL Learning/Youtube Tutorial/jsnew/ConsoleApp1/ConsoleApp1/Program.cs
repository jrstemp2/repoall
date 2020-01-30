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
            int w1 = word1.Length / 2;
            int w2 = word1.Length - w1;
            int count = 0;


            for (int i = 0; i < 101; i++)
            {
                count++;
               

                if (count % 2 == 0)
                {
                    word1 = word1.ToUpper();
                }
                else
                {
                    word1 = word1.ToLower();
                }


                if (i % 3 == 0 && i % 5 == 0)
                { 

                    Console.WriteLine(word1);
                }            
                if (i % 3 == 0)
                {
                    Console.WriteLine(word1.Substring(0, w1));
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(word1.Substring(w1, w2));              
                }
                else
                {
                    Console.WriteLine(i);
                }
                

            }
                
              
            
                
            
        }
    }
}
