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


            int[] scores = new int[size];

            int min = scores[0];
            int max = scores[0];
            int score = 0;

            int sum = 0;
            double avg = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Enter a score: ");
                input2 = Console.ReadLine();
                score = int.Parse(input2);
                scores[i] = score;
                Console.WriteLine(scores[i]);
            }
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
                avg = (double)sum / scores.Length;

                if (scores[i] < min)
                {
                    min = scores[i];
                }
                else if(scores[i] > max)
                {
                    max = scores[i];
                }


            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);


        }
    }
}
