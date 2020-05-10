using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Lab3_GradesUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = 0;
            int numberOfA = 0;
            int numberOfB = 0;
            int numberOfC = 0;
            int numberOfD = 0;
            int numberOfF = 0;
            int grade;
            int gradeSum = 0;
            int[] allScores = new int[100]; // array w/ 100 spaces available

            do
            {
                Console.WriteLine("Please enter your grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                allScores[numberOfGrades] = grade;
                gradeSum += grade;
                numberOfGrades++;

                if (grade >= 90)
                {
                    numberOfA++;
                }
                // Doesn't need grade < 90 b/c already checked grade >= 90 in if statement above
                else if (grade >= 80)
                {
                    numberOfB++;
                }
                else if (grade >= 70)
                {
                    numberOfC++;
                }
                else if (grade >= 60)
                {
                    numberOfD++;
                }
                else if (grade > 0) // need b/c checking neg. #
                {
                    numberOfF++;
                }
                else // grade is negative
                {
                    gradeSum -= grade;
                    numberOfGrades--;
                }
            } while (grade >= 0);

            // Calculate average
            if (numberOfGrades == 0)
            {
                Console.WriteLine("No grades were entered");
            }
            else
            {
                double average = gradeSum / numberOfGrades;

                Console.WriteLine("Total number of grades = {0}", numberOfGrades);
                Console.WriteLine("Total number of A's = {0} which is {1:P1}", numberOfA, Math.Round((numberOfA / (double)numberOfGrades)));
                Console.WriteLine("Total number of B's = {0} which is {1:P1}", numberOfB, Math.Round((numberOfB / (double)numberOfGrades)));
                Console.WriteLine("Total number of C's = {0} which is {1:P1}", numberOfC, Math.Round((numberOfC / (double)numberOfGrades)));
                Console.WriteLine("Total number of D's = {0} which is {1:P1}", numberOfD, Math.Round((numberOfD / (double)numberOfGrades)));
                Console.WriteLine("Total number of F's = {0} which is {1:P1}", numberOfF, Math.Round((numberOfF / (double)numberOfGrades)));
                Console.WriteLine("Average = {0}", average);

                // Updated for standard deviation
                double summation = 0;
                for (int x = 0; x < numberOfGrades; x++)
                {
                    double temp = allScores[x] - average;
                    temp *= temp;
                    summation += temp;
                }

                double standardDeviation = Math.Sqrt(summation / (double)numberOfGrades);
                Console.WriteLine("The standard deviation is {0}.", standardDeviation);
            }

            Console.ReadLine();
        }
    }
}
