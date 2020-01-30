using System;//system is a library. This has basic functions in it. 

namespace Variables
{
    class Program
    {
        static void Main(string[] args)//console programs require a Main function. This is the start of the program. 
        {
            //declaring variables. examples bool, string, int, fload, double, decimal, etc
            //variables aka identifier. used for variables, namespace, methods, etc.
            //Methods should to start with a capital letter.
            //double is a double floating point. has 2 dec points uses rounding. 

            //declaring a value
            int a;
            double b;

            //initialize by assigning a value. This can be done on the same line if wanted. such as int numWeeks = 20;
            a = 3;
            b = 3.14;
            int numWeeks = 20;

            a++;//incrementint
            a--;//decrement
            a = a + 2;





            Console.WriteLine("Hello World!");//this is output to the console. 
            Console.ReadLine();
        }
    }
}
