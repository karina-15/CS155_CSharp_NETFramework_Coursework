/// Homework No. 11 Exercise No. 01
/// File Name:      Student.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    // implements IComparable Interface
    class Student : IComparable
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        // default constructor
        public Student()
        {
            FirstName = "Name";
            LastName = "Name";
            Score = 0;
        }

        // full constructor
        public Student(string _first, string _last, int _score)
        {
            FirstName = _first;
            LastName = _last;
            Score = _score;
        }

        // CompareTo method
        // implements Comparable Interface
        public int CompareTo(object obj)
        {
            return this.Score.CompareTo(((Student)obj).Score);
        }

        // ToString method
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-10} {2}", FirstName, LastName, Score);
        }

        // Equals method
        public override bool Equals(object obj)
        {
            var student = obj as Student;
            // return true if first name, lst name, and score
            // are equal, otherwise false
            return student != null &&
                FirstName == student.FirstName &&
                LastName == student.LastName &&
                Score == student.Score;
        }
    }
}
