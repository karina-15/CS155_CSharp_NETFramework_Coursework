/// Homework No. 13 Exercise No. 01
/// File Name:      BMIDriver.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
/// 
/// Problem Statement: p.236 - Try It Out!
/// BMI. In the world of health, a number called a Body Mass
/// Index (BMI) can be calculated for a person given their height
/// and weight. While not perfect, this gives people an idea
/// of how much they weigh compared to their "ideal weight."
/// Using the Person class defined earlier in this chapter,
/// and assuming thet Height is measured in inches and Weight
/// is measured in pounds, the formula for BMI is this:
///     BMI = (703*weight)/height^2
/// 1. Write a query expression to find all people in a list
///     who are overweight, defined by a BMI higher than 25.
/// 2. Write another query expression to find all people who
///     are in their ideal weight, defined by a BMI > 20 and
///     < 25.
/// 
/// 
/// Overall Plan
/// 1. Create Person class 
/// 2. Add method to Person class to calculate Person BMI
/// 3. Create list of Person objects (15 objects)
/// 4. Create query for Person objects with BMI > 25 using
///     LINQ and IEnumerable
/// 5. Display query of overweight Person objects
/// 6. Create query for Person objects with 20 < BMI < 25
///     using LINQ and IEnumerable
/// 7. Display query of ideal weight Person ojects
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class   - BMIDriver.cs
/// Person class - Person.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class BMIDriver
    {
        static void Main(string[] args)
        {
            // create list of Person objects
            List<Person> people = new List<Person>();

            // add 15 people to list
            people.Add(new Person("Selina",  "Kyle",     23, 67, 138));
            people.Add(new Person("Daniel",  "Rand",     33, 71, 175));
            people.Add(new Person("Arthur",  "Curry",    33, 73, 325));
            people.Add(new Person("Steven",  "Rogers",   99, 74, 220));
            people.Add(new Person("Anthony", "Stark",    53, 73, 225));
            people.Add(new Person("Brian",   "Braddock", 25, 78, 257));
            people.Add(new Person("Scott",   "Summers",  30, 75, 195));
            people.Add(new Person("Barry",   "Allen",    27, 72, 195));
            people.Add(new Person("Carol",   "Danvers",  29, 71, 124));
            people.Add(new Person("Hal",     "Jordan",   20, 74, 186));
            people.Add(new Person("Stephen", "Strange",  42, 74, 180));
            people.Add(new Person("Bruce",   "Wayne",    48, 74, 210));
            people.Add(new Person("Clint",   "Barton",   38, 75, 230));
            people.Add(new Person("Donna",   "Troy",     23, 69, 140));
            people.Add(new Person("Barbara", "Gordon",   21, 67, 135));

            // query for overweight people (BMI > 25)
            IEnumerable<Person> overweight = from   person in people
                                             where  person.calculateBMI() > 25
                                             select person;
            // display overweight people
            Console.WriteLine("Overweight People".PadLeft(32, '-').PadRight(48, '-'));
            Console.WriteLine(String.Format("{0,-18} {1,-5} {2,-8} {3,-9} {4}",
                "Name", "Age", "Height", "Weight", "BMI"));
            foreach (Person person in overweight)
            {
                Console.WriteLine(person);
            }

            // query for ideal weight people (20 < BMI < 25)
            IEnumerable<Person> ideal = from    person in people
                                        where   person.calculateBMI() > 20 &&
                                                person.calculateBMI() < 25
                                        select  person;
            // display ideal weight people
            Console.WriteLine();
            Console.WriteLine("Ideal Weight People".PadLeft(33, '-').PadRight(48, '-'));
            Console.WriteLine(String.Format("{0,-18} {1,-5} {2,-8} {3,-9} {4}",
                "Name", "Age", "Height", "Weight", "BMI"));
            foreach (Person person in ideal)
            {
                Console.WriteLine(person);
            }


            Console.ReadLine();  // prevents window from closing
        }
    }
}
