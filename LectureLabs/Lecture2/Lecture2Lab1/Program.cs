using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add 3 numbers for you.");
            Console.WriteLine("Enter one number and press enter,\n"
                + "then enter second number and press enter,\n"
                + "and enter third number and press enter:");

            // declare two integer variables
            int n1, n2, n3, sum, multiply;
            double divide;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());


            // calculate the sum of these three numbers
            sum = n1 + n2 + n3;
            // calculate multiplication of three numbers
            multiply = n1 * n2 * n3;
            // calculate sum of 3 numbers divided by multiplication of 3 numbers
            divide = Convert.ToDouble(sum) / Convert.ToDouble(multiply);

            // print a message along with the sum of the three numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);
            // print a message along with the multiplication of the three numbers
            Console.WriteLine("The multiplication of those three numbers is");
            Console.WriteLine(multiply);
            // print a message along with the result of dividing the sum by product of 3 numbers
            Console.WriteLine("The result of dividing the sum of the 3 numbers"
                + "by the multiplication of the 3 numbers is");
            Console.WriteLine(divide);

            //Just to pause the screen.
            Console.ReadLine();
        }
    }
}
