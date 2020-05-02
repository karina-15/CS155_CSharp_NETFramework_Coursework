using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab3_LINQ
{
    class Lecture13Lab3_LINQ
    {
        static void Main(string[] args)
        {
            // create list
            List<Person> allPeople = new List<Person>();
            // add 10 people to allPeople list
            allPeople.Add(new Person("Karina", "Elias", 30, 70, 190));
            allPeople.Add(new Person("Julian", "Martinez", 10, 55, 100));
            allPeople.Add(new Person("Melanie", "Cervantes", 25, 60, 120));
            allPeople.Add(new Person("Eric", "Smith", 21, 80, 210));
            allPeople.Add(new Person("Jessica", "Jones", 12, 55, 190));
            allPeople.Add(new Person("Bruce", "Wayne", 66, 74, 200));
            allPeople.Add(new Person("Kara", "Craig", 43, 58, 125));
            allPeople.Add(new Person("Martha", "Stewart", 9, 45, 133));
            allPeople.Add(new Person("David", "Jackson", 38, 70, 180));
            allPeople.Add(new Person("Michael", "Madison", 5, 39, 50));

            // LINQ for people eligible for kids menu
            IEnumerable<Person> kidsMenu = from person in allPeople
                                           where person.Age <= 12
                                           select person;

            Console.WriteLine("-----Eligible for Kids Menu-----");
            foreach (Person kid in kidsMenu)
            {
                Console.WriteLine(kid);
            }

            // Calculate average height of allPeople
            int sumHeight = 0;
            foreach(Person person in allPeople)
            {
                sumHeight += person.Height;
            }
            double avgHeight = Convert.ToDouble(sumHeight) / allPeople.Count();

            // LINQ of people taller than average height
            IEnumerable<Person> aboveAvgHeight = from person in allPeople
                                                 where person.Height > avgHeight
                                                 select person;

            Console.WriteLine("\n-----Taller Than Average Height-----");
            foreach(Person tall in aboveAvgHeight)
            {
                Console.WriteLine(tall);
            }

            Console.ReadKey();
        }
    }
}
