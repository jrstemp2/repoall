using System;
using System.Text.RegularExpressions;

namespace Regexexample
{
    class Program
    {
        static void Main(string[] args) 
        {


            //want a full name, first and last
            Console.Write("PLease enter firstname lastname:");
            string name = Console.ReadLine();

            string pattern = @"^[A-z'-]+\s+[A-z'-]+$";//validates a name format ^$ is checking only the string
            
            
            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Is Valid");
            }
            else
            {
                Console.WriteLine("Is not valid");
            }
            





        }
    }
}
