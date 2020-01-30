using System;
using System.Collections.Generic;

namespace UdemyArraysQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain = "y";
            string name;
            int i = 0;
       
            

            List<string> names = new List<string>();

            do
            {

                Console.Write("Please Enter a name: ");
                name = Console.ReadLine();
              

                if (name == "")
                {
                    break;
                }
                names.Add(name);

            } while (goAgain != "n");

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }


        }
    }
}
