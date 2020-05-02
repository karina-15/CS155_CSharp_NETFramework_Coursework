using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8Lab2_Fraction
{
    class Fraction
    {
        /**
         * Properties - Instance variables and Getters/Setters
         */
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

        public int Denominator
        {
            get {
                if (_denominator == 0)
                {
                    return 1;
                }
                else
                {
                    return _denominator;
                }
            }
            set
            {
                _denominator = value;
            }
        }

        /**
         * Constructors
         */
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int _numerator, int _denominator)
        {
            this.Numerator = _numerator;
            this.Denominator = _denominator;
        }

        public Fraction(Fraction fraction)
        {
            this.Numerator = fraction._numerator;
            this.Denominator = fraction._denominator;
        }

        public double Division(int _numerator, int _denominator)
        {
            double value = Convert.ToDouble(_numerator) / _denominator;
            return value;
        }

        public int FindMinimum(int _numerator, int _denominator)
        {
            if (Math.Abs(_numerator) < Math.Abs(_denominator))
            {
                return _numerator;
            }
            else
            {
                return _denominator;
            }
        }
        public string ReducedFraction(int _numerator, int _denominator)
        {
            /** GCF
             * int min = findMinimum(_numerator, _denominator)
             * int gcf = 1;
             * 
             * for(int x = min; x >=1; x--)
             *      if _numerator and _denominator are divisible (%)
             *          then x is gcf
             *          exit loop
             */
            int min = FindMinimum(_numerator, _denominator);
            int gcf = 1;

            for (int i = min; i >= 1; i--)
            {
                if ((_numerator % i == 0) && (_denominator % i == 0))
                {
                    gcf = i;
                    break;
                }
                else
                {
                    continue;
                }
            }
            _numerator /= gcf;
            _denominator /= gcf;
            string strFraction = String.Format("{0}/{1}", _numerator, _denominator);
            return strFraction;
        }
    }
}
