/// Homework No. 11 Exercise No. 01
/// File Name:      StudentDriver.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
/// 
/// Problem Statement: For this project you will be combining
/// several concepts. Create a Student class and have the Student
/// Class implement the IComparable interface. This interface
/// will compare the Student’s score. The Student class with
/// also have first and last name fields. Create the appropriate
/// constructors as well as getters and setters for the Student
/// class.
/// Create a Student information file. The file is organized
/// the same way as the Student class. An example is shown below:
/// Philip Rivers 91
/// Tom Brady 49
/// Sam Darnold 92
/// Pete Carroll 87
/// Deion Sanders 77
/// Joe Montana 99
/// Read in this file and populate a List of Students. After
/// the list of students is created you will need to compute
/// the average and median of student scores. You will write
/// this information out to a file called StudentStats.txt.
/// As a reminder the median calculation will vary whether there
/// is an odd or even number of elements in the list.
/// Hint: To make this assignment more object oriented you
/// may want to wrap the student class inside another class
/// that allows you to compute all the various aspects that
/// you need.
/// 
/// 
/// Overall Plan
/// 1. Create Student class with first name, last name, and
///     score. Implement IComparable interface, CompareTo method
/// 2. Create StudentStats class with list of Student objects
/// 3. Read from StudentInfo.txt file and store in Student list
/// 4. Sort Student list in order of lowest scores to highest
///     scores
/// 5. Calculate average of scores
/// 6. Calculate median of scores
/// 7. Write stats to StudentStat.txt file
/// 8. Display Student list and stats to console
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class                          - StudentDrivr.cs
/// implements IComparable interface    - Student.cs
/// calculate stats                     - StudentStats.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class StudentDriver
    {
        static void Main(string[] args)
        {
            // files to read from and write to
            string fileInput = "StudentInfo.txt";
            string fileOutput = "StudentStats.txt";

            // read students info from file
            Console.WriteLine("\n-------Student List--------");
            StudentStats studentStats = new StudentStats("../../" + fileInput);
            Console.WriteLine(String.Format("\nRead from {0} file and sorted list", fileInput));

            // sort student list and display to console
            Console.WriteLine("\n----Sorted Student List----");
            studentStats.DisplayStudentList();

            // write stats to file
            Console.WriteLine("\n------Student Stats--------");
            studentStats.WriteStats("../../" + fileOutput);
            Console.WriteLine(String.Format("\nWrote stats to {0} file", fileOutput));

            Console.ReadLine(); // prevents window from closing
        }
    }
}
