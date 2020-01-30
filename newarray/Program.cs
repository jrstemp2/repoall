using System;

namespace ArrayExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please specify how many scores you would like to add: ");
            string input = Console.ReadLine();
            int size = int.Parse(input);
            string input2;
            int score = 0;
            int sum = 0;
            double avg = 0;


            int[] scores = new int[size];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter a score: ");
                input2 = Console.ReadLine();
                score = int.Parse(input2);
                scores[i] = score;
            }

            /*   can also do this 
             *   Console.Write($"Enter a score {i + 1}");  i + 1 is showing 1- size insead of 0 -(size -1). this shifts the index for the user. 
             *   scores[i] = int.Parse(Console.ReadLine());
             * 
             * */

            
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
                Console.WriteLine("Which score do you want to upatda: ");
                int index = int.Parse(Console.ReadLine());

                
                if (index <= 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
                if (index >0 )
                {



                    index--;//shift index back
                    Console.WriteLine("Wat is the new score? (was {scores[index]}})");


                    //update the array
                    scores[index] = int.Parse(Console.ReadLine());

                    //more demo
                }
            }while (flag);











            //Array.Sort(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            int[] arr = scores; //this is an alias for scores. meaning arr and scores point to the same array now and cam change eachother. 

            //copying the array using copyto method.
            int[] arr2 = new int[scores.Length + 5];//we have to create a big enough space to copy this array. 
            scores.CopyTo(arr2, 0); //the arr is the aray and the 0 is the index or where you will start copying to. 0 is the start point. 

            Console.WriteLine();
            for (int i = 0; i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            


           














        }
    }
}
