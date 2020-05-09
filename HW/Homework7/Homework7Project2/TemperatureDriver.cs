/// Homework No. 07 Exercise No. 02
/// File Name:      TemperatureDriver.cs
/// @author:        Karina Elias
/// Date:           Oct 21, 2019
/// 
/// Problem Statement: Write a Temperature class that has two
/// instance variables: a temperature value (a floating-point
/// number) and a character for the scale, either C for Celsius
/// or F for Fahrenheit. The class should have 4 constructor
/// methods: one for each instance variable (assume zero degress
/// if no value is specified and Celsius if no scale is specified),
/// one with two parameters for the two instance variables,
/// and a no-argument constructor (set to zero degrees Celsius).
/// 
/// 
/// Overall Plan
/// 1. Write Temperature class
/// 2. Define instance variables
/// 3. Write 4 constructors
/// 4. Write methods
/// 5. Create Temperature objects
/// 6. Test all methods and constructors
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - TemperatureDriver.cs
/// Temperature class - Temperature.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Project2
{
    class TemperatureDriver
    {
        static void Main(string[] args)
        {
            // temp1 tests temp instance variable constructor
            Temperature temp1 = new Temperature(23.7);
            Console.WriteLine("Temp1: " + temp1.ToString());
            Console.WriteLine("GetTempC method call: " + temp1.GetTempC().ToString());  // 23.7C
            Console.WriteLine("GetTempF method call: " + temp1.GetTempF().ToString());  // temp1 in F
            temp1.SetTemp(21.3);                                                        // set temp to 21.3
            Console.WriteLine("After SetTemp method call: " + temp1.ToString());
            temp1.SetScale('c');                                                        // set scale to C
            Console.WriteLine("After SetScale method call: " + temp1.ToString());
            temp1.SetAll(81.2, 'f');                                                    // set temp & scale to 81.2F
            Console.WriteLine("After SetAll method call: " + temp1.ToString());
            Console.WriteLine("GetTempC method call: " + temp1.GetTempC().ToString());  // 81.2F in C

            // temp2 tests scale instance variable constructor
            Temperature temp2 = new Temperature('f');
            Console.WriteLine("Temp2: " + temp2.ToString());
            temp2.SetAll(72.9, 'f');

            // temp3 tests full constructor
            Temperature temp3 = new Temperature(72.9, 'f');
            Console.WriteLine("Temp3: " + temp3.ToString());

            // tests Equals method true
            Console.WriteLine("Temp2 = Temp3: " + temp2.Equals(temp3));
            // tests Equals method false
            Console.WriteLine("Temp1 = Temp2: " + temp1.Equals(temp2));

            // temp4 tests no-argument constructor
            Temperature temp4 = new Temperature();
            Console.WriteLine("Temp4: " + temp4.ToString());

            Console.ReadKey();  // keeps window from closing
        }
    }
}
