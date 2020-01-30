using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool is only true or false
            bool isMale = true;
            bool isTall = true;


            // && for and, || for or
            if(isMale == true &&  isTall == true)
            {
                Console.WriteLine("You are male");
                Console.WriteLine("You are tall"); 
            }
            else
            {
                Console.WriteLine("You are Female");
                Console.Write("You are not a tall male");
            }


            Console.ReadLine();

        }
    }
}
