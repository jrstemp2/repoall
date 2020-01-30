using System;

namespace methods1
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = GetInt("Please specify how many scores you would like to add: ");
            int score = 0;
            int sum = 0;
            double avg = 0;

            int[] scores = new int[size];

            for (int i = 0; i < scores.Length; i++)
            {
                score = GetInt("Enter a score: ");
                scores[i] = score;
            }

            int min = scores[0];
            int max = scores[0];

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
                avg = (double)sum / scores.Length;

                if (scores[i] < min)
                {
                    min = scores[i];
                }
                else if (scores[i] > max)
                {
                    max = scores[i];
                }
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine();

            bool flag = true;
            do
            {
                //output scores with more user friendly indices. 
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"{i + 1}\t{scores[i]}");
                }

                //ask which score they want to updtae.
                int index = GetInt("Which score do you want to upatda: ");
         
                if (index <= 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
                if (index > 0)
                {
                    index--;//shift index back
                    Console.WriteLine("Wat is the new score? (was {scores[index]}})");
                    //update the array
                    scores[index] = int.Parse(Console.ReadLine());
                }
            } while (flag);

            Array.Sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            int[] arr = scores; //this is an alias for scores. meaning arr and scores point to the same array now and cam change eachother. 

            //copying the array using copyto method.
            int[] arr2 = new int[scores.Length + 5];//we have to create a big enough space to copy this array. 
            scores.CopyTo(arr2, 0); //the arr is the aray and the 0 is the index or where you will start copying to. 0 is the start point. 

            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }


        //new method goes here. reuseble block of code. 
        //method header names it and gives more info to compliler. 4-5 parts. 
        //return type - what info does the method give back. void if none returning. 
        //static means you dont need a new instance of the variable. static means calling it out of main. 
        //name of method follows rules of identifiers. start with caps. PascalCase. 
        //arguement or parameter list. What info is it gettin to start.
        //method signature is made up of the name and parameter types. 
        
        static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        

    }
}
