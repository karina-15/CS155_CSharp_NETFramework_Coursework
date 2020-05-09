/// Homework No. 07 Exercise No. 01
/// File Name:      OdometerDriver.cs
/// @author:        Karina Elias
/// Date:           Oct 21, 2019
/// 
/// Problem Statement: Define a class called Odometer that
/// will be used to track fuel usage and miles per gallon.
/// Create two constructors, 1 constructor should be the
/// no-argument constructor the other will set the two
/// instance variables. The class should have instance
/// variables for mileage driven and fuel used.  Include a
/// reset method that sets the mileage drive and the fuel
/// used to zero. Include an add method which takes two
/// parameters that add to the fuel consumed and the miles
/// driven. Finally create a method that returns the miles
/// per gallon and an appropriate ToString method. Write a
/// driver program that tests all the methods and constructors.
/// Make sure that you protect against division by zero.
/// 
/// 
/// Overall Plan
/// 1. Write Odometer class
/// 2. Define instance variables
/// 3. Write 2 constructors
/// 4. Write methods
/// 5. Create Odometer objects
/// 6. Test all methods
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - OdometerDriver.cs
/// Odometer class - Odometer.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Project1
{
    class OdometerDriver
    {
        static void Main(string[] args)
        {
            // no-argument constructor
            Odometer meter1 = new Odometer();
            Console.WriteLine("After creating no-arg Odometer object\n" + meter1.ToString());
            meter1.Add(50, 5);
            Console.WriteLine("After calling Add method\n" + meter1.ToString());
            meter1.Add(25, 3);
            Console.WriteLine("After calling Add method again\n" + meter1.ToString());
            meter1.Reset();
            Console.WriteLine("After calling Reset method\n" + meter1.ToString());
            Console.WriteLine();

            // full constructor
            Odometer meter2 = new Odometer(100, 10);
            Console.WriteLine("After creating full Odometer object\n" + meter2.ToString());
            meter2.Add(10, 2);
            Console.WriteLine("After calling Add method\n" + meter2.ToString());
            meter2.Add(8, 1);
            Console.WriteLine("After calling Add method again\n" + meter2.ToString());
            meter2.Reset();
            Console.WriteLine("After calling Reset method\n" + meter2.ToString());

            Console.ReadKey();  // keeps window from closing
        }
    }
}
