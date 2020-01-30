using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //[] tells the systemen we are making an array. Elements go inside the {}
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            //creating a new string and adding [5] to show the array can hold 5 values
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            //adding a number
            luckyNumbers[1] = 50;

            //accessing the elements in the array. use an index in [] to pick an element from an array.
            Console.WriteLine(luckyNumbers[4]);// picking the 5th element in the arry with [4]

            for(int x = 0; x < 6; x++)
            {
                Console.WriteLine(friends[x]);
                Console.ReadLine();

                //range based for loops
                
            }
            

            Console.ReadLine();
        }
    }
}
