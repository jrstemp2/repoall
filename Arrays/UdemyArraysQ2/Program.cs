using System;

namespace UdemyArraysQ2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();

            //Now i need to build an array of characters
            char[] nameArray = new char[name.Length];


            //now we need a loop to reverse the name
            //i is set to equal the length of the array
           // i-- is starting at the end of the name. 

           


            for (int i = name.Length; i>0; i--)
            {
                nameArray[name.Length - i] = name[i - 1];
                // if john i = 4
                //nameArray[name.Length - i] THIS IS SETTING THE START POINT TO 0. 
                //USING THE NAME JOHN NAME. LENGTH IS 4. 4-1 IS 3. 
                //J - 0
                //O - 1
                //H - 2
                //N - 3
                //SO WE ARE RESETTING THE INDEX TO 0. 

                //= name[i - 1]; THIS PIEC IS TAKING i, WHICH IS THE LENGTH OF THE ARRAY
                //AND SUBRTACTING ONE. IN THIS CASE 4-1 = 3. wE ARE SAYING START AT INDEX 3
                //WHICH IS THE LAST LETTER IN THE NAME JOHN. N = 3 IS NOW N = 0

            }

            string reversed = new string(nameArray);
            Console.WriteLine(reversed);
            

            

            

        }
    }
}
