using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lecture 1 Lab 3
/// </summary>
namespace Lecture1Lab3
{
    class Program
    {
        // CONSTANTS
        public const string GREETING = "Hi";

        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Print greeting:\n" + GREETING);
            Console.WriteLine();

            // prefix increment
            // Increment before/after variable
            int n = 2;
            Console.WriteLine("n = {0}", n);
            int valueProduced = 2 * (++n);
            Console.WriteLine("Prefix increment:\n"
                + "2 * (++n) = {0}, n = {1}", valueProduced, n);
            // Console.WriteLine(valueProduced);
            // Console.WriteLine(n);
            Console.WriteLine();

            // postfix increment
            int m = 2;
            Console.WriteLine("m = {0}", m);
            valueProduced = 2 * (m++);
            Console.WriteLine("Postfix increment:\n"
                + "2 * (m++) = {0}, m = {1}", valueProduced, m);
            // Console.WriteLine(valueProduced);
            // Console.WriteLine(m);
            Console.WriteLine();

            // substring
            string collegeName = "Mira Costa";
            Console.WriteLine("string: {0}", collegeName);
            Console.WriteLine("substring(5): {0}", collegeName.Substring(5));    // prints Costa
            Console.WriteLine("substring(0, 3): {0}", collegeName.Substring(0, 3)); // prints Mir

            // keep window open
            Console.ReadLine();
        }
    }
}

/*
 * Multi line comment
 */
