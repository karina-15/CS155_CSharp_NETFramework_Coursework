/// Homework No. 07 Exercise No. 01
/// File Name:      Odometer.cs
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
    class Odometer
    {
        // instance variables
        private double mileage; // milage used
        private double fuel;    // fuel used

        // constructors
        /** no-argument */
        public Odometer()
        {
            mileage = 0;
            fuel = 0;
        }

        /** full constructor */
        public Odometer(double mileage, double fuel)
        {
            this.mileage = mileage;
            this.fuel = fuel;
        }

        // methods
        /** Reset */
        public void Reset()
        {
            mileage = 0;
            fuel = 0;
        }

        /** Add */
        public void Add(double mileage, double fuel)
        {
            this.mileage += mileage;
            this.fuel += fuel;
        }

        /** Mpg */
        public double Mpg()
        {
            if(fuel <= 0)
            {
                return 0;
            }
            else
            {
                double mpg = mileage / fuel;
                return mpg;
            }
        }

        /** ToString */
        public override string ToString()
        {
            return String.Format("Milage used: {0}" +
                "\nFuel used: {1}" +
                "\nMPG = {2:N2}\n", 
                mileage, fuel, Mpg());
        }
    }
}
