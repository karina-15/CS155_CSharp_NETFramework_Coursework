﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_FizzBuzz
{
    class Lecture5_FizzBuzz
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 100; x++)
            {
                if(x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
    }
}
