/// Homework No. 04 Exercise No. 02
/// File Name:      Homework4Project2.cs
/// @author:        Karina Elias
/// Date:           Sep. 22, 2019
/// 
/// Problem Statement: Write a program that will print out
/// statistics for 8 coin tosses. User will input either "h"
/// for heads or "t" for tails. The program will then print
/// out the total number and percentages of heads and tails.
/// 
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Initialize a counter variable to 0
/// 3. Start a while loop (count < 8)
/// 4. Prompt user for heads or tails
/// 5. After for loop goes through 8 times calculate percentage
///     of heads and tails
/// 6. Display total number and percentages of heads and tails
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

namespace Homework4Project2
{
    class Homework4Project2
    {
        // constants
        const int TOTAL = 8;

        static void Main(string[] args)
        {
            // Print introduction
            Console.WriteLine("This program will show statistics" +
                " for 8 coin tosses.");
            Console.WriteLine("For each coin toss enter either" +
                    " 'h' for heads or 't' for tails.");
            Console.WriteLine();

            // ---INPUT---
            int count = 0;
            int heads = 0;
            int tails = 0;
            double hPercent;
            double tPercent;
            string hOrT;

            while(count < TOTAL)
            {
                Console.Write("Toss {0}: ", Convert.ToString(count + 1));
                hOrT = Console.ReadLine();

                if(hOrT.ToLower()[0] == 'h')
                {
                    heads++;
                    count++;
                }
                else if(hOrT.ToLower()[0] == 't')
                {
                    tails++;
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Try again");
                }
            }

            // ---PROCESS---
            hPercent = (Convert.ToDouble(heads) / TOTAL) * 100;
            tPercent = (Convert.ToDouble(tails) / TOTAL) * 100;

            // ---OUTPUT---
            Console.WriteLine();
            Console.WriteLine("Number of heads: {0}", heads);
            Console.WriteLine("Number of tails: {0}", tails);
            Console.WriteLine("Percent heads: {0,4:N1}", hPercent);
            Console.WriteLine("Percent tails: {0,4:N1}", tPercent);

            Console.ReadLine(); // Pauses screen
        }
    }
}
