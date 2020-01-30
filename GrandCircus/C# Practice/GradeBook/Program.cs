using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the GradeBook!");

            while (true) //this loop will never end.
            {
                Console.Write("Please enter percentage grade: ");
                string input = Console.ReadLine();
                double pctGrade = double.Parse(input);
                char ltrGrade = ' ';

                if (pctGrade >= 90)
                {
                    ltrGrade = 'A';
                }
                else if (pctGrade >= 80)
                {
                    ltrGrade = 'B';
                }
                else if (pctGrade >= 70)
                {
                    ltrGrade = 'C';
                }
                else if (pctGrade >= 60)
                {
                    ltrGrade = 'D';
                }
                else
                {
                    ltrGrade = 'F';
                }
                Console.WriteLine("Your Grade is an : " + ltrGrade);
            }

        }
    }
}
