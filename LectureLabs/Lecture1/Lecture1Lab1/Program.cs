using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print message to screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter,\nthen enter second number and press enter:");

            // declare 3 variable integers
            int n1, n2, sum, product;
            double division;
            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());

            // calculate sum, product, & division
            sum = n1 + n2;
            product = n1 * n2;
            division = sum / product;

            // display results
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("Division = " + division);

            // pause screen
            Console.ReadLine();
        }
    }
}
