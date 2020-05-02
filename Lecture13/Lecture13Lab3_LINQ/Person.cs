using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab3_LINQ
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Person(string fname, string lname, int age, int height, int weight)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, {2} yo, {3} in., {4} lb.", FirstName, LastName, Age, Height, Weight);
        }
    }
}
