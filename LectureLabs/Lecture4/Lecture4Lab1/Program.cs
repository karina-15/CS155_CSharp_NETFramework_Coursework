using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit, clockedSpeed, fine;

            Console.WriteLine("Enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the clocked speed: ");
            clockedSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (clockedSpeed > speedLimit)
            {
                Console.WriteLine("The speed is illegal.");
                if (clockedSpeed > speedLimit)
                {
                    fine = FINE + (FINE_EA_MILE * (clockedSpeed - speedLimit));
                    if (clockedSpeed > (speedLimit + EXCESS_SPEED))
                    {
                        fine = EXCESS_FINE + FINE + (FINE_EA_MILE * (clockedSpeed - speedLimit));
                    }
                    Console.WriteLine("The fine = ${0}", fine);
                }
            }
            else
            {
                Console.WriteLine("The speed is legal.");
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit program.");
            Console.ReadLine();
        }
    }
}
