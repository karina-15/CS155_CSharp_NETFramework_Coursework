using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab1_Fraction
{
    class Lecture9Lab1_Fraction
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();    // use integers

            Console.WriteLine("This program will find calculate the decimal" +
                "\nof a fraction and reduce it to the lowest terms.\n");

            Console.Write("Enter an integer for the numerator: ");
            fraction1.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer for the denominator: ");
            fraction1.Denominator = Convert.ToInt32(Console.ReadLine());

            int num1 = fraction1.Numerator;
            int num2 = fraction1.Denominator;

            double division = fraction1.Division(num1, num2);
            Console.WriteLine(String.Format("{0}/{1} = {2:N2}", num1, num2, division));

            string strFraction = fraction1.ReducedFraction(num1, num2);
            Console.WriteLine("{0}/{1} reduces to {2}", num1, num2, strFraction);

            Console.ReadLine();
        }
    }
}
