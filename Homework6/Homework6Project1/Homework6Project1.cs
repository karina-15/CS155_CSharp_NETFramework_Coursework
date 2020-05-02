/// Homework No. 06 Exercise No. 01
/// File Name:      Homework6Project1.cs
/// @author:        Karina Elias
/// Date:           Oct 06, 2019
/// 
/// Problem Statement: Define a class called Counter whose
/// objects count things. An object of this class records
/// a count that is a nonnegative integer. Include methods
/// to set the counter to 0, to increase the count by 1, and
/// to decrease the count by 1. Be sure that no method allows
/// the value of the counter to become negative. Include a
/// getter method that returns the current count value and
/// a method that outputs the count to the screen. There should
/// be no input method or other setter methods. The only method
/// that can set the counter is the one that sets it to 0.
/// Include a ToString methods and a Equals method. Write a
/// driver program that include a menu to interactively test
/// each method in your program. For example, the menu should
/// have an option that test each method and operates on 1
/// object for example you should be able to select the
/// increment method which would increment your Counter.
/// 
/// 
/// Overall Plan
/// 1. Initialize Counter object which sets count to 0
/// 2. Initialize menu choice to 0
/// 3. Print menu in a while loop
/// 4. Prompt user for menu choice
/// 5. Compare with switch statement
/// 6. Execute option
/// 7. Display count value
/// 8. Exit while loop / program when option 5 is chosen
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework2Part2
/// Counter class - Counter.cs

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6Project1
{
    class Homework6Project1
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            int choice = 0;

            // Menu
            while (choice != 5)
            {
                Console.WriteLine("\n-----Counter Menu-----");
                Console.WriteLine("1. Display counter");
                Console.WriteLine("2. Increase counter by 1");
                Console.WriteLine("3. Decrease counter by 1");
                Console.WriteLine("4. Reset counter to 0");
                Console.WriteLine("5. Exit program");

                // ---INPUT---
                Console.Write("\nEnter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                // ---PROCESS/OUTPUT---
                switch (choice)
                {
                    case 1:
                        c1.PrintCounter();
                        break;
                    case 2:
                        c1.IncreaseBy1();
                        Console.WriteLine("Increase count by 1\n" + c1.ToString());
                        break;
                    case 3:
                        if (c1.GetCounter() == 0)
                        {
                            Console.WriteLine("Counter cannot be negative.");
                        }
                        else if(c1.GetCounter() != 0)
                        {
                            Console.WriteLine("Decrese count by 1");
                        }
                        c1.DecreaseBy1();
                        Console.WriteLine(c1.ToString());
                        break;
                    case 4:
                        c1.ResetCounter();
                        Console.WriteLine("Reset count to 0\n" + c1.ToString());
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            Console.ReadKey();  // keeps window from closing
        }
    }
}
