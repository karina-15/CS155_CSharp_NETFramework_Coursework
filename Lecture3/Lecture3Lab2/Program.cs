using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Lamp doesn't work." +
                "\nIs the lamp plugged in? ");
            input = Console.ReadLine();

            if (input.Substring(0, 1).ToLower() == "y")
            {
                Console.WriteLine("Is the bulb burned out? ");
                input = Console.ReadLine();
                if (input.Substring(0, 1).ToLower() == "y")
                {
                    Console.WriteLine("Replace bulb.");
                }
                else
                {
                    Console.WriteLine("Repair lamp.");
                }
            }
            else
            {
                Console.WriteLine("Plug in lamp.");
            }

            Console.ReadKey();
        }
    }
}
