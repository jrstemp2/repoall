using System;

namespace NestedFors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Outcomes of rolling 2 Dice");

            for (int die2 = 1; die2 <= 6; die2++)
            {

                Console.Write("\t" + die2);
            }
            Console.WriteLine();//skip a line


            for (int die1 = 1; die1 <= 6; die1++)
            {
                Console.Write(die1 + "|");

                //This is for die 2
                for (int die2 = 1; die2 <= 6; die2++)
                {

                    Console.Write("\t" + (die1 + die2));
                }
                Console.WriteLine();//skip a line

                

            }




        }
    }
}
