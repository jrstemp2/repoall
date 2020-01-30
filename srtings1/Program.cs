using System;

namespace srtings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jim";
            string name2 = "Bob";


            string name3 = name + name2;
            string name4 = String.Concat(name, name2);

            Console.WriteLine(name3);
            Console.WriteLine(name4);

            string winner = name;  //winner is now pointing to the same address as name. 
            name = "Peter";//reassigns to peter
            Console.WriteLine(winner);// winner is still pointing to jim since it comes before the name reassign. 

            string sentence = "The purple cow won the lottery";
            Console.WriteLine($"Sentence length: {sentence.Length}");
            Console.WriteLine($"cow index is {sentence.IndexOf("cow")}");

            sentence = sentence.ToLower();//sets it to lower to ignore case sensitivity 

            int cow = sentence.IndexOf("cow");
            if (cow > 0)
            {
                Console.WriteLine($"Cow is at index: {cow}");
            }



        }
    }
}
