using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Fraction
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
            {
            this.numerator = numerator;
            SetDenominator(this.denominator);
}

        public Fraction(Fraction fraction)
            {
            this.numerator = fraction.numerator;
            this.denominator = fraction.denominator;
}
        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public void SetNumerator(int numerator)
        {
            this.numerator = numerator;
        }


        public void SetDenominator(int denominator)
        {
            if(denominator == 0)
            {
                this.denominator = 1;
            }
            else
            {
                this.denominator = denominator;
            }
        }

        public double division(int numerator, int denominator)
        {
            double value = Convert.ToDouble(numerator) / denominator;
            return value;
        }

        public int findMinimum(int numerator, int denominator)
        {
            if(numerator < denominator)
            {
                return numerator;
            }
            else
            {
                return denominator;
            }
        }
        public string reducedFraction(int numerator, int denominator)
        {
            /** GCF
             * int min = findMinimum(numerator, denominator)
             * int gcf = 1;
             * 
             * for(int x = min; x >=1; x--)
             *      if numerator and denominator are divisible (%)
             *          then x is gcf
             *          exit loop
             */
            int min = findMinimum(numerator, denominator);
            int gcf = 1;

            for(int i = min; i >= 1; i--)
            {
                if((numerator % i == 0) && (denominator % i == 0))
                {
                    gcf = i;
                    break;
                }
                else
                {
                    continue;
                }
            }
            numerator = numerator / gcf;
            denominator = denominator / gcf;
            string strFraction = String.Format("{0}/{1}", numerator, denominator);
            return strFraction;
        }
    }
}
