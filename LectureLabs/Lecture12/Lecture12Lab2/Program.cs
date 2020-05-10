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
            RollDice dice1 = new RollDice("dice1", _color:"red");   // named parameter _color
            RollDice dice2 = new RollDice("dice2", _sides: 3);      // named parameter _sides
            Console.WriteLine(String.Format("Sides of {0} {1}: {2}\n" +
                "Sides of {3} {4}: {5}", dice1.Color, dice1.Name, dice1.Sides,
                dice2.Color, dice2.Name, dice2.Sides));

            
            Console.ReadKey();  // prevents window from closing
        }

        class RollDice
        {
            public string Name { get; set; }
            public int Sides { get; set; }
            public string Color { get; set; }

            // Optional parameters
            // 6 sides is the optional parameter
            public RollDice(string _name, int _sides = 6, string _color = "white")
            {
                Name = _name;
                Sides = _sides;
                Color = _color;
            }

        }
    }
}
