using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab2_3DVectors
{
    class Lecture13Lab2_3DVectors
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(3, 3, 3);
            // Add
            Console.Write("v1 + v2 = ");
            Console.WriteLine(v1 + v2);
            // Subtract
            Console.Write("v1 - v2 = ");
            Console.WriteLine(v1 - v2);
            // Negate (2, 0, -4) = (-2, 0, 4)
            Vector v3 = new Vector(2, 0, -4);
            Console.Write("-v3 = ");
            Console.WriteLine(-v3);
            // Multiply (1, 2, 3) * 4 = (4, 8, 12)
            Console.Write("v1 * 4 = ");
            Console.WriteLine(v1 * 4);
            // Divide (2, 4, 6)/2 = (1, 2, 3)
            Vector v4 = new Vector(2, 4, 6);
            Console.Write("v4 / 2 = ");
            Console.WriteLine(v4 / 2);

            Console.ReadKey();
        }
    }
}
