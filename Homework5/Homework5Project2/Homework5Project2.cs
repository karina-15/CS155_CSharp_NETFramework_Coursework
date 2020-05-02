/// Homework No. 05 Exercise No. 02
/// File Name:      Homework5Project2.cs
/// @author:        Karina Elias
/// Date:           Sep. 30, 2019
/// 
/// Problem Statement: Try It Out! Copying an Array p.83
///     Write code to create a copy of an array with size 10.
/// 
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Create an initial array with 10 items
/// 3. Create a 2nd array of the same size and type using Length
/// 4. Use a loop to read values from the original array
/// 5. Place them into the new array.
/// 6. Display the contents of both arrays.
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework5Part2

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Project2
{
    class Homework5Project2
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            // Print introduction
            Console.WriteLine("This program will create a copy of an array.\n");

            // ---INPUT---
            // Create initial array of with values in it of size 10
            int[] numArr = new int[SIZE] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Create a 2nd empty array of same size 10
            int[] copyArr = new int[numArr.Length];

            // Print contents of array before the copy loop
            // using printArray(int[] array) method
            Console.WriteLine("Before copy:");
            Console.Write("numArr = [ ");
            printArray(numArr);
            Console.Write("copyArr = [ ");
            printArray(copyArr);
            
            // ---PROCESS---
            // Loops through 1st array and copies
            // its contents into the 2nd array
            for (int index = 0; index < numArr.Length; index++)
            {
                copyArr[index] = numArr[index];
            }

            // ---OUTPUT---
            Console.WriteLine("After copy:");
            Console.Write("numArr = [ ");
            printArray(numArr);
            Console.Write("copyArr = [ ");
            printArray(copyArr);

            Console.ReadLine(); // keeps window from closing
        }

        /** printArray(int[] array) method
         * Prints all the contents of the passed array when called
         * using a for loop and Length
         */
        static void printArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.Write("]\n");
        }
    }
}
