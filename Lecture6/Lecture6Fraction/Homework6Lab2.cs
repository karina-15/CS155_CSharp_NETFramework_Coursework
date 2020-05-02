using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Homework6Lab2
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();

            Console.WriteLine("This program will find calculate the decimal" +
                "\nof a fraction and reduce it to the lowest terms.\n");

            Console.Write("Enter an integer for the numerator: ");
            fraction1.SetNumerator(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter an integer for the denominator: ");
            fraction1.SetDenominator(Convert.ToInt32(Console.ReadLine()));

            int num1 = fraction1.GetNumerator();
            int num2 = fraction1.GetDenominator();

            double division = fraction1.division(num1, num2);
            Console.WriteLine(String.Format("{0}/{1} = {2:N2}", num1, num2, division));

            string strFraction = fraction1.reducedFraction(num1, num2);
            Console.WriteLine("{0}/{1} reduces to {2}", num1, num2, strFraction);

            Console.ReadLine();
        }
    }
}
