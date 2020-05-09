using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Optional Parameters
            RollDice dice1 = new RollDice();
            RollDice dice2 = new RollDice(3);
            Console.WriteLine(String.Format("Sides of dice1: {0}\n" +
                "Sides of dice2: {1}", dice1.Sides, dice2.Sides));

            Console.ReadKey();  // prevents window from closing
        }

        class RollDice
        {
            public int Sides { get; set; }

            // Optional parameters
            // 6 sides is the optional parameter
            public RollDice(int sides = 6)
            {
                Sides = sides;
            }
        }
    }
}
