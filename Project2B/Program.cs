using System;

namespace Project2B
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade are you expecting to get in ISM 4300?");
                string expectedGrade = Console.ReadLine();
                int finalGrade = int.Parse(expectedGrade);

                if ((finalGrade <= 100) && (finalGrade >= 93))
                {
                    Console.WriteLine("You made an A+");
                }
                else if ((finalGrade <= 92) && (finalGrade >= 90))
                {
                    Console.WriteLine("You made an A");
                }
                else if ((finalGrade <= 89) && (finalGrade >= 87))
                {
                    Console.WriteLine("You made a B+");
                }
                else if ((finalGrade <= 86) && (finalGrade >= 83))
                {
                    Console.WriteLine("You made a B");
                }
                else if ((finalGrade <= 82) && (finalGrade >= 80))
                {
                    Console.WriteLine("You made a B-");
                }
                else if ((finalGrade <= 79) && (finalGrade >= 77))
                {
                    Console.WriteLine("You made a C+");
                }
                else if ((finalGrade <= 76) && (finalGrade >= 73))
                {
                    Console.WriteLine("You made a C");
                }
                else if ((finalGrade <= 72) && (finalGrade >= 70))
                {
                    Console.WriteLine("You made a C-");
                }
                else if ((finalGrade <= 69) && (finalGrade >= 67))
                {
                    Console.WriteLine("You made a D+");
                }
                else if ((finalGrade <= 66) && (finalGrade >= 63))
                {
                    Console.WriteLine("You made a D");
                }
                else if ((finalGrade <= 62) && (finalGrade >= 60))
                {
                    Console.WriteLine("You made a D-");
                }
                else if ((finalGrade <= 59) && (finalGrade >= 0))
                {
                    Console.WriteLine("You made an F");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Input a valid integer");
            }
        }
    }
}
