using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5Lab2_GuessingGame
{
    class Lecture5Lab2_GuessingGame
    {
        static void Main(string[] args)
        {
            Random generator = new Random();    // creates Random object
            int guess;
            int r = generator.Next(101);    // creates random number between 0-100
            int count = 1;

            Console.Write("Try to guess the number between 0-100." +
                "\n\nEnter a number: ");
            guess = Convert.ToInt32(Console.ReadLine());
            while (guess != r)
            {
                if (guess < 0 || guess > 100)
                {
                    Console.Write("Invalid guess.\nGuess again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess < r)
                {
                    Console.Write("Guess higher: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess > r)
                {
                    Console.Write("Guess lower: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                count++;
            }
            Console.WriteLine("\nYou guessed right.\nThe number is {0}." +
                        "\nTotal number of guesses = {1}.", r, count);

            Console.ReadLine();
        }
    }
}
