/// Homework No. 13 Exercise No. 01
/// File Name:      Person.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Person
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        // full constructor
        public Person(string _first, string _last, int _age,
            int _height, int _weight)
        {
            FirstName = _first;
            LastName = _last;
            Age = _age;
            Height = _height;
            Weight = _weight;
            calculateBMI();
        }

        // calculate BMI
        public double calculateBMI()
        {
            return Math.Round((703.0 * Weight) / (Height * Height), 2);
        }

        // ToString method
        public override string ToString()
        {
            return String.Format("{0,-7} {1,-9} {2} yo  {3} in.  {4} lbs.  {5}",
                FirstName, LastName, Age, Height, Weight, calculateBMI());
        }
    }
}
