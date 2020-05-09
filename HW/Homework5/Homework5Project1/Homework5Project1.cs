/// Homework No. 05 Exercise No. 01
/// File Name:      Homework5Project1.cs
/// @author:        Karina Elias
/// Date:           Sep. 30, 2019
/// 
/// Problem Statement: Write a program that asks the user to
/// enter the size of a triangle to print out (an integer from
/// 1 to 50), then print the triangle by printing a series of
/// lines consisting of asterisks.
/// 
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Prompt user for size of triangle
/// 3. Check if input is in valid range (while loop)
/// 4. Display rows of asterisks (for loop)
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework5Part1

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Project1
{
    class Homework5Project1
    {
        static void Main(string[] args)
        {
            int size;
            // Print introduction
            Console.WriteLine("This program will print out a triangle" +
                " using asterisks.\n");

            // ---INPUT---
            Console.WriteLine("Enter the size of a triangle (integer 1-50): ");
            size = Convert.ToInt32(Console.ReadLine());

            while(size < 1 || size >50) // valid entry check
            {
                Console.WriteLine("Invlid entry. Enter an integer 1-50: ");
                size = Convert.ToInt32(Console.ReadLine());
            }

            // ---PROCESS / OUTPUT---
            // prints each row until the size input is reached
            for (int column = 0; column <= size; column++)
            {
                printStars(column);
            }
            // 1 row past the half-way point
            // start printing 1 less star for each row
            for(int column = size - 1; column > 0; column--)
            {
                printStars(column);
            }

            Console.ReadLine(); // keeps window from closing
        }

        /** printStars(int column) method
         * used to print a single row of asterisks
         */
        static void printStars(int column)
        {
            while(column != 0)
            {
                Console.Write('*');
                column--;
            }
            Console.WriteLine();
        }
    }
}
