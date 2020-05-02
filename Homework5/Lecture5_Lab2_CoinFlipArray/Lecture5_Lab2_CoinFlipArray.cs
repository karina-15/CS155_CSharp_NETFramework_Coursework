using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Lab2_CoinFlipArray
{
    class Lecture5_Lab2_CoinFlipArray
    {
        // enumeration for coin
        public enum Coin { Heads, Tails };
        // constant
        const int FLIPS = 8;
        static void Main(string[] args)
        {
            Random rand = new Random();
            // variables
            int heads = 0;
            int tails = 0;
            // array size of total # of flips
            int[] coinArr = new int[FLIPS];

            // places each flip result (0 or 1) in array
            for(int index = 0; index < FLIPS; index++)
            {
                coinArr[index] = Convert.ToInt32(coinFlip(rand)); // only 2 options
                if(coinArr[index] == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Results(coinArr, heads, tails);
            Console.ReadLine(); // keeps window from closing
        }

        static Coin coinFlip(Random rand)
        {
            if(rand.Next(2) == 0)
            {
                return Coin.Heads;
            }
            else
            {
                return Coin.Tails;
            }
        }

        static void Results(int[] coinArr, int heads, int tails)
        {
            foreach(int element in coinArr)
            {
                if(element == 0)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }
            double headsPercent = Convert.ToDouble(heads) / FLIPS * 100;
            double tailsPercent = Convert.ToDouble(tails) / FLIPS * 100;

            Console.WriteLine("Heads: {0}\nPercentage: {1}%", heads, headsPercent);
            Console.WriteLine("Tails: {0}\nPercentage: {1}%", tails, tailsPercent);
        }

/*        // constant
        const int FLIPS = 8;

        static void Main(string[] args)
        {
            Random rand = new Random();
            int flip;
            int heads = 0;
            int tails = 0;
            double headsPercent;
            double tailsPercent;

            for (int index = 0; index < FLIPS; index++)
            {
                // 0 or 1 b/c index starts at 0 add 1 to end of range
                flip = rand.Next(2);
                if (flip == 0)
                {
                    heads++;
                    Console.WriteLine("Flip {0}: Heads", index + 1);
                }
                else
                {
                    tails++;
                    Console.WriteLine("Flip {0}: Tails", index + 1);
                }
            }
            headsPercent = Convert.ToDouble(heads) / FLIPS * 100;
            tailsPercent = Convert.ToDouble(tails) / FLIPS * 100;
            Console.WriteLine("Heads: {0}\nPercent heads: {1}%", heads, headsPercent);
            Console.WriteLine("Tails: {0}\nPercent tails: {1}%", tails, tailsPercent);

            Console.ReadLine(); // keeps window from closing
        }*/
    }
}
