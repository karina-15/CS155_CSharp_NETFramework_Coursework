using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Midterm_StudentRecord
{
    class Lecture7Midterm_StudentRecord
    {
        static void Main(string[] args)
        {
            int[] qArr = new int[3];
            qArr[0] = 7;
            qArr[1] = 7;
            qArr[2] = 6;
            int count = 0;
            StudentRecord s1 = new StudentRecord(qArr, 88, 75);
            s1.OverallGrade();

            // display grades
            foreach(int element in qArr)
            {
                count++;
                Console.WriteLine("Quiz {0} score: {1}", count, element);
            }
            Console.WriteLine("Midterm score: {0}\nFinal score: {1}\n", 
                s1.GetMidterm(), s1.GetFinal());

            Console.WriteLine(s1.ToString());

            Console.ReadLine(); // Keep window open
        }
    }
}
