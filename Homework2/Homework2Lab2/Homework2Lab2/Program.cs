using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Lab2
{
    class Program
    {
        // Constants
        const int couponCandyBars = 10;
        const int couponGumBalls = 3;

        static void Main(string[] args)
        {
            // Variables
            String userInput;
            int couponsWon, candyBars, couponsLeft, gumBalls;

            // Input:
            Console.WriteLine("Enter number of coupons won");
            userInput = Console.ReadLine();
            couponsWon = Convert.ToInt32(userInput);

            // Process:
            candyBars = couponsWon / couponCandyBars;
            couponsLeft = couponsWon % couponCandyBars;
            gumBalls = couponsLeft / couponGumBalls;

            // Output:
            Console.WriteLine("You can get at most " + candyBars + " candy bars.");
            Console.WriteLine("You can then get " + gumBalls + " with the remaining coupons.");

            Console.ReadLine();
        }
    }
}
