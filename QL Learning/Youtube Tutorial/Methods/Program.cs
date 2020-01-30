using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)//this is the main method. everything is executed here
        {
            


            //Call the method I created here. John and 33 are the name and age 
            //i am passing through to the new method 
            SayHi("John", 33);

            Console.ReadLine();

        }

        //New Method goes outside of the Main Method. 
        //void is a return type. Void does not return info.
        //Passing the string name John through the method. 
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "You Are " + age);
        }









    }
}
