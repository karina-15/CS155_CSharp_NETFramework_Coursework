using System;
using System.Collections.Generic;
/// Homework No. 11 Exercise No. 01
/// File Name:      StudentStats.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class StudentStats
    {
        // list to store student information
        private List<Student> studentList = new List<Student>();

        // full constructor
        // reads from file, displays list, and sorts list
        public StudentStats(string fileInput)
        {
            ReadFile(fileInput);
            DisplayStudentList();
            studentList.Sort();
        }

        // ReadFile method stores student information into list
        public void ReadFile(string fileInput)
        {
            // open and close file
            using (StreamReader sr = new StreamReader(fileInput))
            {
                string line = null;
                // while end of file is not reached
                while((line = sr.ReadLine()) != null)
                {
                    string[] lineWords = line.Split();
                    string first = lineWords[0];
                    string last = lineWords[1];
                    int score = Convert.ToInt32(lineWords[2]);
                    studentList.Add(new Student(first, last, score));
                }
            }
        }

        // calculate average of student list
        public double CalculateAverage()
        {
            double sumTotal = 0;
            // add all students scores in list
            foreach(Student student in studentList)
            {
                sumTotal += student.Score;
            }
            // return average
            return sumTotal / studentList.Count;
        }

        // calculate median of students in list
        public double CalculateMedian()
        {
            int middleIndex = studentList.Count / 2;
            // if odd number of scores, return middle score
            if (studentList.Count == 1 || studentList.Count % 2 != 0)
            {
                return studentList[middleIndex].Score;
            }
            // if even number of scores,
            // return average of both middle scores
            else
            {
                return (studentList[middleIndex - 1].Score +
                    studentList[middleIndex].Score) / 2.0;
            }
        }

        // write stats to file
        public void WriteStats(string fileOutput)
        {
            using (StreamWriter sw = new StreamWriter(fileOutput))
            {
                // display on console
                Console.WriteLine(String.Format("Average: {0}\nMedian: {1}",
                    CalculateAverage(), CalculateMedian()));
                // write to file
                sw.WriteLine(String.Format("Average: {0}", CalculateAverage()));
                sw.WriteLine(String.Format("Median: {0}", CalculateMedian()));
            }
        }

        // displays all students' information in list to console
        public void DisplayStudentList()
        {
            Console.WriteLine("{0,-10} {1,-10} {2}", "First Name", "Last Name", "Score");
            foreach(Student student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
