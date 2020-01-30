using System;

namespace editingarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };


            // updateding the spelling of Wednesday
            daysOfWeek[2] = "Wednesday";
            // list all days of the week in order

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
