using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 75, 93, 88, 91 };
            int sum = 0;
            double aver = 0;
            int min = scores[0];
            int max = scores[0];//safest is ti set this to the first value of the array


            //add, average and find the min and max of the array above.
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];

                if (scores[i] < min)
                {
                    min = scores[i];
                }
                else if (scores[i] > max)
                {                       //scores[i] starts at index 0 and goes through the max index.  
                    max = scores[i];//as loop goes, [i] is the current number in the index cycle. 
                }
            }
            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            for (int i = 0; i < scores.Length; i++)
            {
                aver = (double)sum / scores.Length;//(double) is casting sum as a double
            }
            Console.WriteLine("Average: " + aver);

            
            //this sorts the array scores. 
            Array.Sort(scores);

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

        }//ask user for num of scores
        //take input for each score and put into arrat   int[] scores;
    }
}
