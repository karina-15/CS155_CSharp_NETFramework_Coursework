/// Homework No. 03 Exercise No. 02
/// File Name:      MainWindow.xaml.cs
/// @author:        Karina Elias
/// Date:           Sep. 16, 2019
/// 
/// Problem Statement: Write a program that determines the
/// change to be dispensed from a vending machine. An item
/// in the machine can cost between 25 cents and 1 dollar,
/// in 5-cent increments (25, 30, 35, ..., 95, 100), and
/// the machine accepts only a single dollar bill to pay
/// for the item.
/// 
/// Overall Plan
/// 1. Print introduction
/// 2. Declare constants for dollar, quarter, dime, & nickel
/// 3. Prompt user for price of item
/// 4. Validate if entered price is b/w 25-100 & 5 cent increment
/// 5. Calculate total change 
///     (change = dollar - price)
/// 6. Calculate quarters in change
///     (quarter_change = change / QUARTER)
/// 7. Update remaining change
///     (change = change % QUARTER)
/// 8. Calculate dimes in change
///     (dime_change = change / DIME)
/// 9. Update remaining change
///     (change = change % DIME)
/// 10. Calculate nickels in change
///     (nickel_change = change / NICKEL)
/// 11. Display outputs in corresponding labels
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework3Project2

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3Project2
{
    class Homework3Project2
    {
        // constants
        const int DOLLAR = 100;
        const int QUARTER = 25;
        const int DIME = 10;
        const int NICKEL = 5;

        static void Main(string[] args)
        {
            // Variables
            int price;  // input
            int change, quarter_change, dime_change, nickel_change; // output

            // Print introduction
            Console.WriteLine("This program will return the change dispensed from a vending machine.");

            // ---INPUT---
            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments):");
            price = Convert.ToInt32(Console.ReadLine());

            // Validate user input
            while(price > 100 || price < 25 || ((price % 5) != 0))
            {
                Console.WriteLine("Invalid price. Please try again.");
                price = Convert.ToInt32(Console.ReadLine());
            }

            // ---PROCESS---
            change = DOLLAR - price;
            quarter_change = change / QUARTER;
            change = change % QUARTER;
            dime_change = change / DIME;
            change = change % DIME;
            nickel_change = change / NICKEL;

            // ---OUTPUT---
            Console.WriteLine("You bought an item for {0} cents and gave me a dollar," +
                " so your change is", price);
            Console.WriteLine("{0} quarters,\n{1} dimes, and\n{2} nickels.",
                quarter_change, dime_change, nickel_change);

            Console.ReadLine(); // Keep window open
        }
    }
}
