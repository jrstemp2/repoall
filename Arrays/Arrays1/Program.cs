using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //collections have the same kind of data type in them. Arrays are a collection in C#.
            //Arrays, ArrayList, Dictionary, Hashtable - all homogeneous. 
            //Arrays contain elements. 
            //can not change size. size is declared when initialized. uses 0 indexing. 
            //new int[16] says find me 16 new continuous spaces for the ints. 
            //array initializes all of the values. ints are  0, booleans are false which is 0. strings are null.

            //string[] names = new string[2] { "John", "Stempowski" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}type[] arrayName = new type[];

            //declaration and instantiation . spaced in memory allocated and all elements are 0's out. 
            //int[] scores = new int[16];

            //declaration only. reference variable is created bu no space is allocated in memory yet.
            //string[] names;//these 2 go together. code can be in between. 
            //instatiation only. 16 spaces are created in memory and all values are nulled. 
            //names = new string[16];//this is an empty array with 16 spaces.



            //Console.Write("Please enter a class size: ");
            //string input = Console.ReadLine();
            //int size = int.Parse(input);
            //int[] scores1 = new int[size];


            //you can delcare an array with information to stert with
            //Sets 4 spaces aside and assignes the values in the {}. 
            //this use on lab since we know what is already 
            //string[] names = { "Adam", "Bella", "Charlie", "Dave" };//this is an example of parallel arrays. 2 arrays the same size holing related info
            //int[] scores = {75, 93, 88, 70};

            //for (int i = 0; i < names.Length; i++)//print the array
            //{

            //Console.WriteLine(names[i]);
            //Console.WriteLine(scores[i]);
            //    Console.WriteLine($"{i}.\t{names[i]}\t{scores[i]}");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //changes the value in the array.
            //names[3] = "Peter";
            //scores[3] = 100;
            //scores[3] += 50; //adds to the score value, not array size. 

            //for (int i = 0; i < names.Length; i++)//print the array
            //{

            //    //Console.WriteLine(names[i]);
            //    //Console.WriteLine(scores[i]);
            //    Console.WriteLine($"{i}.\t{names[i]}\t{scores[i]}");
            //}



            Console.WriteLine("HOw many students: ");
            string input1 = Console.ReadLine();
            int size = int.Parse(input1);

            string[] names = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                
            }
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
    


        }
    }
}
