using System;
using System.Collections.Generic;

namespace moreLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });//initialize by adding an array

            foreach (int number in numbers)//used to print the list. 
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));//start search from beginning
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));//start search on end of lest

            Console.WriteLine("Count: " + numbers.Count);// copunts objects in a list. 

            //numbers.Remove(1);//removes first 1

            //This is to remove all occurances of 1 from the list. Must use standard for Loop to do this. 
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);//cant do this. 
                }    
            }
            
            foreach (int number in numbers)//used to print the list. 
            {
                Console.WriteLine(number);
            }

        }
    }
}
