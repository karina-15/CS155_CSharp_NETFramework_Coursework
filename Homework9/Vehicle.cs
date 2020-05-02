/// Homework No. 09 Exercise No. 01
/// File Name:      Vehicle.cs
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
    public enum Manufacturer
    {
        Volkswagon,
        Honda,
        Ford,
        Toyota,
        Nissan,
        GM,
        Hyundai,
        Chevy
    }

    class Vehicle : Person
    {
        /** Properties **/
        public string Name
        {
            get;
            set;
        }
        public int Cylinder
        {
            get;
            set;
        }
        public Person Owner
        {
            get;
            set;
        }

        /** Constructors **/
        public Vehicle(Person _owner) : base(_owner)
        {
            Name = Enum.GetName(typeof(Manufacturer), 2);
            Cylinder = 4;
        }

        public Vehicle(string _name, int _cylinder, Person _owner) : base(_owner)
        {
            Name = _name;
            Cylinder = _cylinder;
        }

        /** ToString **/
        public override string ToString()
        {
            String vehicleStr = "Vehicle " + base.ToString() +
                String.Format("\nManufacturer: {0}\nCylinders: {1}", Name, Cylinder);
            return vehicleStr;
        }
    }
}
