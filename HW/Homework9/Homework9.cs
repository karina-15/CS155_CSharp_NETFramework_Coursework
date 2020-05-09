/// Homework No. 09 Exercise No. 01
/// File Name:      Homework9.cs
/// @author:        Karina Elias
/// Date:           Nov 04, 2019
/// 
/// Problem Statement: Create a class called Vehicle that
/// has the Manufracturer name (enum), number of Cyclinders
/// in the engine (int), and the owner (Person, see below).
/// Then create a class called Truck that is derived from
/// Vehicle and has the additional following properties: the
/// load capacity in tons (double), and towing capacity in
/// pounds (int). Be sure your class has a reasonable set of
/// constructors, getters/setters, properties and suitably
/// defined ToString and Equals methods. Write a driver program
/// to test all your methods.
/// 
/// 
/// Overall Plan
/// 1. Complete Person class 
/// 2. Write Vehicle class
///     owner uses Person class
/// 3. Write Truck class
///     derived from Vehicle class
///     add variables for load capacity and towing capacity
/// 4. Write Homework9 as driver to test all class constructors
///     and methods
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework9.cs
/// Person class - Person.cs
/// Vehicle - Vehicle.cs
/// Truck - Truck.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Homework9
    {
        static void Main(string[] args)
        {
            // create 3 Person objects
            Person p1 = new Person("Bob");
            Console.WriteLine("Person 1: " + p1.ToString());
            Person p2 = new Person("John");
            Console.WriteLine("Person 2: " + p2.ToString());
            Person p3 = new Person("John");
            Console.WriteLine("Person 3: " + p3.ToString());

            // test Person Equals method
            Console.WriteLine("p1 = p2? " + p1.Equals(p2));
            Console.WriteLine("p2 = p3? " + p2.Equals(p3));
            
            // test Vehicle class
            Vehicle vehicle1 = new Vehicle(p1);
            Console.WriteLine("Vehicle 1: " + vehicle1.ToString());
            Vehicle vehicle2 = new Vehicle(Enum.GetName(typeof(Manufacturer), 0), 4, new Person("Betty"));
            Console.WriteLine("Vehicle 2: " + vehicle2.ToString());
            // test Truck class
            Truck truck1 = new Truck(Enum.GetName(typeof(Manufacturer), 7), 8, p2, 0.75, 5000);
            Console.WriteLine("Person 1: " + truck1.ToString());

            Console.ReadKey();  // prevents window from closing
        }
    }
}
