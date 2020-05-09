/// Homework No. 02 Exercise No. 02
/// File Name:      Homework2Part2.cs
/// @author:        Karina Elias
/// Date:           Sep. 07, 2019
/// 
/// Problem Statement: Write a program that converts
/// degrees Fahrenheit to Celsius. User can enter a whole
/// number for Fahrenheit and program will display Celsius
/// with 1 decimal point.
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Prompt user for temperature in degrees Fahrenheit
/// 3. Use int32 to convert input to int
/// 4. Calculate degrees Celsius using formula:
///     degreesC = 5*(degreesF-32)/9
/// 5. Display the temperature in degrees Celsius
///     to 1 decimal point using Math.Round(number, decimal)
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework2Part2

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Part2
{
    class Homework2Part2
    {
        static void Main(string[] args)
        {
            // ---Variables---
            String userInput;
            double degreesF, degreesC;

            // Print introduction
            Console.WriteLine("This program will convert a temperature");
            Console.WriteLine(" from degrees Fahrenheit to Celsius.\n");


            // ---Input---
            // Get degrees Fahrenheit
            Console.Write("Enter temperature in degrees Fahrenheit: ");
            userInput = Console.ReadLine();         // ReadLine takes in type string
            degreesF = Int32.Parse(userInput);      // convert string input to int
            Console.WriteLine();


            // ---Process---
            // Convert degreesF int to double
            //degreesF = Convert.ToDouble(degreesF);
            // Calculate degrees Celsius using formula
            degreesC = 5 * (degreesF - 32) / 9;


            // ---Output---
            // Print degrees F to degrees C
            Console.WriteLine(degreesF + " degrees Fahrenheit = "
                + Math.Round(degreesC, 1) + " degrees Celsius");



            Console.ReadLine(); // Pauses screen
        }
    }
}
