/// Homework No. 02 Exercise No. 01
/// File Name:      Homework2Part1.cs
/// @author:        Karina Elias
/// Date:           Sep. 07, 2019
/// 
/// Problem Statement: Write user's name in pig latin.
/// Take the 1st letter of the first name to the end,
/// add "ay", and capitalize the new pig latin name.
/// Do the same for the last name.
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Prompt user for first name
/// 3. Prompt user for last name
/// 4. Use substrings to manipulate first & last name
/// 5. Concatenate first & last name with "ay" at end
/// 6. Use ToUpper method to capitalize 1st letter of
///     each name
/// 7. Display names in pig latin
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework2Part1

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Part1
{
    class Homework2Part1
    {
        static void Main(string[] args)
        {
            // ---Variables---
            String first, last;
            String firstPigLatin, lastPigLatin;

            // Print introduction
            Console.WriteLine("This program will write your" +
                " name in pig latin.\n");


            // ---Input---
            // Get user's first name
            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            first = first.ToLower();    // makes all lowercase
            // Get user's last name
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();
            last = last.ToLower();      // makes all lowercase
            Console.WriteLine();


            // ---Process---
            // Substring index starts @ 0
            // Substring(1) = 2nd char to end of word
            // Substring(0, 1) = 1st char only
            firstPigLatin = first.Substring(1) + first.Substring(0, 1) + "ay";
            lastPigLatin = last.Substring(1) + last.Substring(0, 1) + "ay";
            // ToUpper method to capitalize 1st letter of each name
            firstPigLatin = char.ToUpper(firstPigLatin[0]) + firstPigLatin.Substring(1);
            lastPigLatin = char.ToUpper(lastPigLatin[0]) + lastPigLatin.Substring(1);


            // ---Output---
            // Print name in pig latin
            Console.WriteLine("Name in pig latin: " + firstPigLatin + " " + lastPigLatin);


            Console.ReadLine(); // Pauses screen
        }
    }
}
