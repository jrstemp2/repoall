using System;

namespace breaksandcontinue
{
    class Program
    {
        static void Main(string[] args)
        {

             
            Console.WriteLine("This adds positive numbers");
            int sum = 0;
            int num = 0;

            //while (true)
            //{
            //    Console.Write("Enter a nmber: ");
            //    string input = Console.ReadLine();
            //    int num = int.Parse(input);

            //    if (num == -999)
            //    {
            //        break;
            //    }
            //    if (num >= 0)
            //    {
            //        sum += num;
            //        continue;
            //    }

            while (num != -999 )
            {
                Console.Write("Enter a nmber: ");
                string input = Console.ReadLine();
                num = int.Parse(input);

          
                if (num >= 0)
                {
                    sum += num;
                    continue;
                }
            }
            Console.WriteLine("The Total is " + sum);

        }
    }
}
