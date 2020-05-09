using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4Lecture4Lab3
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

            do
            {
                Console.WriteLine("Please enter your grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
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
            if(numberOfGrades == 0)
            {
                Console.WriteLine("No grades were entered");
            }
            else
            {
                double average = gradeSum / numberOfGrades;

                Console.WriteLine("Total number of grades = {0}", numberOfGrades);
                Console.WriteLine("Total number of A's = {0} which is {1}%", numberOfA, Math.Round((numberOfA / (double)numberOfGrades) * 100));
                Console.WriteLine("Total number of B's = {0} which is {1}%", numberOfB, Math.Round((numberOfB / (double)numberOfGrades) * 100));
                Console.WriteLine("Total number of C's = {0} which is {1}%", numberOfC, Math.Round((numberOfC / (double)numberOfGrades) * 100));
                Console.WriteLine("Total number of D's = {0} which is {1}%", numberOfD, Math.Round((numberOfD / (double)numberOfGrades) * 100));
                Console.WriteLine("Total number of F's = {0} which is {1}%", numberOfF, Math.Round((numberOfF / (double)numberOfGrades) * 100));
                Console.WriteLine("Average = {0}", average);
            }

            Console.ReadLine();
        }
    }
}
