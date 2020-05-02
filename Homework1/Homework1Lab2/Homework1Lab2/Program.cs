using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Homework Lab
/// </summary>

namespace Homework1Lab2
{
    class Program
    {
        // CONSTANTS
        public const string GREETING = "Hi";
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine(GREETING);
            Console.ReadLine();

            // Imcrement before/after variable
            int n = 2;
            int valueProduced = 2 * (++n);
            Console.WriteLine("{0}, {1}", valueProduced, n);
            // Console.WriteLine(valueProduced);
            // Console.WriteLine(n);

            int m = 2;
            valueProduced = 2 * (m++);
            Console.WriteLine("{0}, {1}", valueProduced, m);
            // Console.WriteLine(valueProduced);
            // Console.WriteLine(m);

            Console.ReadKey();

            String collegeName = "Mira Costa";
            Console.WriteLine(collegeName.Substring(5));    // prints Costa
            Console.WriteLine(collegeName.Substring(0, 3)); // prints Mir
        }
    }
}

/*
 * Multi line comment
 */
