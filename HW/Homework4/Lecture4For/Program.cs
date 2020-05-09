using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x = x + 2)
            {
                Console.WriteLine("x = {0}", x);
            }

            Console.WriteLine();

            // nested for loop executes 100 time (10 * 10)
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("x = {0}", x);
                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine("y = {0}, x = {1}", y, x);
                }
            }

            Console.ReadLine();
        }
    }
}
