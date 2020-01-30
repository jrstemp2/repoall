using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array - fixed number of items in an order. Not Mutable. 
            //Days of the week example


            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            // list all days of the week in order

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("Which day would you like to display? ");
            Console.Write("Monday = 0 ....... Sunday = 7");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay - 1];// this makes it so the used can use a 1 instead of 0
            Console.WriteLine(chosenDay);

            string lastDay = daysOfWeek[1];

            Console.WriteLine("The Second day is " + lastDay);
            Console.ReadLine();

            //1 based indexing




        }
    }
}
