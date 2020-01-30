using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)//this is the main method. everything is executed here
        {

            //to print the result being returned we do the following while passing a number into the new mehtod.
            //Console.WriteLine(cube(5));


            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();

        }

        //we are going to return a number so do not use void. We will use int to return an interger. 
        //passing an interger num into the method
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
       









    }
}
