using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Lab5_Try
{
    class Lecture6Lab5_Try
    {
        static void Main(string[] args)
        {
            int[] scoreList = new int[10];

            try
            {
                Console.WriteLine("We are intializing the array.");

                // = causes indexOutOfRangeException
                // if e.g. divide by zero would be caught by Exception e
                // w/o errors will still execute finally block
                // let's initialize my array
                for (int i = 0; i <= 10; i++)
                {
                    scoreList[i] = 1;
                }

            }
            // this one must come after the specific ones.
            catch (IndexOutOfRangeException e) // a specific exception
            {
                Console.WriteLine("Something bad with the array probably happened.\n" + e);
            }
            catch (Exception e) // this is the general exception
            {
                Console.WriteLine("something bad happened.\n" + e);
            }
            finally // always execute after a catch ends
            {
                Console.WriteLine("we are done");
            }

            Console.ReadKey();
        }
    }
}
