using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            /*best to prevent the bad input rather than throwing and catching 
             * an exception. 
           
             * start with specific exceptions first. Exception is more general than FormatException. 
             * 
             * 
             * 
            */

            while (true)// using a non int will create an error.
            {
                Console.Write("Give me a number: ");

                try
                {
                    n = int.Parse(Console.ReadLine());// this line can cause an exception
                }    
                catch(Exception e)//e is the variable storing the exception. This catches all exceptions or errors from input. 
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                finally
                {
                    Console.WriteLine("MIschief Managed");//this is where you do your clean up. Optional. close connecton to the database, etc. 
                }
                Console.WriteLine("You entered " + n);
            }

            


        }
    }
}
