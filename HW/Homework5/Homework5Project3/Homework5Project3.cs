/// Homework No. 05 Exercise No. 03
/// File Name:      Homework5Project3.cs
/// @author:        Karina Elias
/// Date:           Sep. 30, 2019
/// 
/// Problem Statement: Try It Out! Reversing an Array p.97
///     Write a program that uses methods to reverse the contents of
///     an array.
///     Use 3 methods: 1 to create the array, 1 to reverse the array,
///     and 1 to print the array at the end.
///     GenerateNumbers method should return an array of 10 numbers.
///     PrintNumber method should simply use a foreach loop to go
///     down the array and print out the items in it.
///     Reverse method will swap 2 values, 1 from the 1st half of the
///     array and the other from the second half of the array, using
///     a temp variable
///     Hint #2 - Use array[index] to swap with
///     array[arrayLength - index - 1] and only loop through half the
///     length of the array.
///     
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Use provided code for Main method which calls each method
/// 3. Code GenerateNumbers method of return type int[]
/// 4. Code PrintNumbers method passing the array as a parameter and
///     no return, using foreach loop
/// 5. Code Reverse method passing the array as a parameter and no 
///     return type
///     Use provided code and a for loop for swap:
///         // Swapping a and b
///         int a = 3;
///         int b = 5;
///         
///         int temp = a;
///         a = b;
///         b = temp;
/// 6. Display the contents of the array
///
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework5Part3

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5Project3
{
    class Homework5Project3
    {
        const int SIZE = 10;
        static void Main(string[] args)
        {
            // Print introduction
            Console.WriteLine("This program will use methods to create and" +
                " reverse an array\n");

            // Provide code from book question
            int[] numbers = GenerateNumbers();
            PrintNumbers(numbers);  // added to show what the array looks like
                                    // before the swap
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.ReadLine(); // keeps window from closing
        }

        // ---INPUT---
        /** GenerateNumbers() method
         * returns the newly created array using a for loop
         * because it returns the array the method is of type int[]
         */
        static int[] GenerateNumbers()
        {
            int[] array = new int[SIZE];
            // loops through entire array
            for (int index = 0; index < SIZE; index++)
                {
                    array[index] = index + 1;
                }
            return array;
        }

        // ---PROCESS---
        /** Reverse(int[] array) method
         * passes array and uses a for loop to get the 1st and 2nd item to swap
         * does not return anything so use void
         */
        static void Reverse(int[] array)
        {
            // array.Length / 2 is used because the 1st half is swapped with
            // the 2nd half of the array
            for (int index = 0; index < array.Length / 2; index++)
            {
                // places content of 1st item in temp
                int temp = array[index];
                // places content of 2nd item into 1st item's original position
                array[index] = array[array.Length - index - 1];
                // places content of 1st item (temp) into 2nd item's
                // original position
                array[array.Length - index - 1] = temp;
            }
        }

        // ---OUTPUT---
        /** PrintNumbers(int[] array) method
         * passes array and uses a foreach loop to print the contents
         * of the entire array
         * does not return anything so use void
         */
        static void PrintNumbers(int[] array)
        {
            Console.Write("[ ");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("]");
        }
    }
}