using System;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool worked = false;
            int n = 0;
            int answer = 0;

            ////Throwing exceptions 


            do
            {
                Console.Write("Please enter a number: ");
                worked = int.TryParse(Console.ReadLine(), out n);

                if (!worked)
                {
                    Console.WriteLine("Sorry, please try again.");
                }
            } while (!worked);


            try
            {
                answer = DoMath(n);//method DoMath returns value to answer.
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Whoops! Guess i used too big of a number!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't use a 0");
            }
             

            Console.WriteLine("The answer is " + answer);
        }
        //preconditions - things expected to be true before the method runs. these should be tested in the code. 
        //key words: throw and throws
        // here are the preconditions made up for this: n can't be 0, negative or more than 10. 


        static int DoMath(int n)//method passing n into it and returning an int 10/n
        {
            //throw exceptions
            if (n <= 0)
            {
                //this should also be an argument exception 
                throw new Exception("You're so wrong");
            }
            else if (n > 10) 
            {
                
                throw new ArgumentException("That number is too big.");
            }
            return 10 / n;
        }
    }
}

