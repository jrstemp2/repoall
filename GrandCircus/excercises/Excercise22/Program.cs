using System;

namespace Excercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, num;
            char key = 'y';
            

            //pompt user to enter 2 numbers that will determine a range
            //Then promt the user to enter another number ad check to see if it is in a range. 

            //TODO Validate user data here. 
            Console.Write("Please enter the lower number of the range: ");
            int.TryParse(Console.ReadLine(), out min);


            Console.Write("Please enter the higher number of the range: ");
            int.TryParse(Console.ReadLine(), out max);


            while (key == 'y')
            { 
                Console.Write("Please enter the number you want to chek in the range: ");
                int.TryParse(Console.ReadLine(), out num);


                if (num > max)
                {
                    Console.WriteLine("This number is higher than the range");
                }
                else if (num < min) //mutually exclusive so use an else if
                {
                    Console.WriteLine("This number is lower than the range");
                }
                else
                {
                    Console.WriteLine("This number is in the range");
                }
                Console.WriteLine("Woule you like to contine (y/n)");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);

                while (key != 'y' && key != 'n')
                {
                    Console.Write("\ninvalid iput, please press y or n");
                    key = Console.ReadKey().KeyChar;
                    key = char.ToLower(key);
                }

                Console.WriteLine();
                
            }
            Console.WriteLine("Thank you, please come again.");
            







        }
    }
}
