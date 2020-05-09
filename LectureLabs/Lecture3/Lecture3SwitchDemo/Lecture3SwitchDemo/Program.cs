using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle is entering?");
            Console.WriteLine("1 - car");
            Console.WriteLine("2 - bus");
            Console.WriteLine("3 - truck");
            Console.WriteLine("Other");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.WriteLine("Please pay $1.50");
                    break;
                case 2:
                    Console.WriteLine("Please pay $2.50");
                    break;
                case 3:
                    Console.WriteLine("Please pay $4.50");
                    break;
                default:
                    Console.WriteLine("Please pay $5.00");
                    break;
            }

            Console.ReadLine();
        }
    }
}
