using System;
namespace NestedFors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Outcomes of Rolling Two Dice:");
            //loop to output the header
            for (int die2 = 1; die2 <= 6; die2++)
            {
                Console.Write($"\t{die2}");
            }
            Console.WriteLine();
            for (int i = 0; i < 54; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            //nested for the table
            for (int die1 = 1; die1 <= 6; die1++)
            {
                Console.Write(die1 + "|");
                for (int die2 = 1; die2 <= 6; die2++)
                {
                    Console.Write($"\t{die1 + die2}");
                }
                Console.WriteLine();//skip a line
            }

        }
    }
}
