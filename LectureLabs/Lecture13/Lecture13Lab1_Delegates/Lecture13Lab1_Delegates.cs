using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Lab1_Delegates
{
    class Lecture13Lab1_Delegates
    {
        // declare delegate
        public delegate int MathDelegate(int a, int b);

        static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;
            int a = 20;
            int b = 5;
            int result = mathOperation(a, b);
            Console.WriteLine(String.Format("Add {0} and {1} = {2}",
                a, b, result));
            mathOperation = Subtract;
            result = mathOperation(a, b);
            Console.WriteLine(String.Format("Subtract {0} and {1} = {2}",
                a, b, result));

            Console.ReadKey();
        }

        // methods to use with delegate
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
