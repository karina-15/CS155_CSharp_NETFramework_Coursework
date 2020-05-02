/// Homework No. 06 Exercise No. 01
/// File Name:      Counter.cs
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
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - Homework2Part2
/// Counter class - Counter.cs

/// Import necessay C# or user-defined packages

/// Create Counter class and objects needed to implement tasks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6Project1
{
    class Counter
    {
        // instance variables
        private int count;

        /** Constructor
         */
        public Counter()
        {
            count = 0;
        }

        /** ResetCounter() method
         * resets counter to 0
         * returns count equal to 0
         */
        public int ResetCounter()
        {
            return count = 0;
        }

        /** IncreaseBy1() method
         * increases counter by 1
         * returns count +1
         */
        public int IncreaseBy1()
        {
            return count++;
        }

        /** DecreaseBy1() method
         * decreases counter by 1 if count is not equal to 0
         * returns count -1
         */
        public int DecreaseBy1()
        {
            if (count == 0)
            {
                return count = 0;
            }
            else
            {
                return count--;
            }
        }

        /** GetCounter() method
         * getter/accessor for count
         * returns count
         */
        public int GetCounter()
        {
            return count;
        }

        /** PrintCounter()
         * Displays count to console
         */
        public void PrintCounter()
        {
            Console.WriteLine("Count = {0}", count);
        }

        /** ToString() method
         * overrides default Object.ToString() method
         * returns string displaying count value to console
         */
        public override String ToString()
        {
            return String.Format("Count = {0}", count);
        }

        /** Equals() method
         * checks if object equal
         */
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Counter c = (Counter)obj;
            return (count == c.count);
        }
    }
}
