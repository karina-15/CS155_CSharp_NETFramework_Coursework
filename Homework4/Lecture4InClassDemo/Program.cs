using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4InClassDemo
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int x = 0;

            // infinite loop
            // while(x != 5)
            while(x < 5)
            {
                x = x + 2;
                Console.WriteLine("x = {0}", x);
            }
            Console.ReadLine();
        }*/

        static void Main(string[] args)
        {
            int numberOfGrades = 0;
            int numberOfA = 0;
            int numberOfB = 0;
            int numberOfC = 0;
            int numberOfD = 0;
            int numberOfF = 0;
            int grade;
            do
            {
                Console.WriteLine("Please enter your grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                numberOfGrades++;
                if(grade >=90)
                {
                    numberOfA++;
                }
                // Doesn't need grade < 90 b/c already checked grade >= 90 in if statement above
                else if (grade >= 80)
                {
                    numberOfB++;
                }
                else if(grade >= 70)
                {
                    numberOfC++;
                }
                else if(grade >= 60)
                {
                    numberOfD++;
                }
                else if(grade > 0) // need b/c checking neg. #
                {
                    numberOfF++;
                }
                else // grade is negative
                {
                    numberOfGrades--;
                }
            } while (grade >= 0);

            Console.WriteLine("Total number of grades = {0}", numberOfGrades);
            Console.WriteLine("Total number of A's = {0} which is {1}%", numberOfA, Math.Round((numberOfA/ (double)numberOfGrades) * 100));
            Console.WriteLine("Total number of B's = {0} which is {1}%", numberOfB, Math.Round((numberOfB/ (double)numberOfGrades) * 100));
            Console.WriteLine("Total number of C's = {0} which is {1}%", numberOfC, Math.Round((numberOfC/ (double)numberOfGrades) * 100));
            Console.WriteLine("Total number of D's = {0} which is {1}%", numberOfD, Math.Round((numberOfD/ (double)numberOfGrades) * 100));
            Console.WriteLine("Total number of F's = {0} which is {1}%", numberOfF, Math.Round((numberOfF/ (double)numberOfGrades) * 100));

            Console.ReadLine();
        }
    }
}
