using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab1
{
    class Program
    {
        private const string BOYS_FILE = "boynames.txt";
        private const string GIRLS_FILE = "girlnames.txt";

        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ' };
            Dictionary<string, Name> boyNames = readFile(BOYS_FILE);
            Dictionary<string, Name> girlNames = readFile(GIRLS_FILE);

            while (Process(boyNames, girlNames))
            {
                // run program
            }
        }

        private static Dictionary<string, Name> readFile(string filename)
        {
            Dictionary<string, Name> info = new Dictionary<string, Name>();
            char[] delimiterChars = { ' ' };    // separated by whitespace

            // read from file
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                int count = 1;

                // read from file until an empty line is reached
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineData = line.Split(delimiterChars);
                    Name nameInfo = new Name();
                    nameInfo.Rank = count;                      // track line #
                    nameInfo.Count = Int32.Parse(lineData[1]);  // # of names in yr
                    info.Add(lineData[0].ToLower(), nameInfo);  // add lowercase name to dict
                    count++;
                }
            }
            return info;
        }

        private static bool Process(Dictionary<string, Name> boyNames, Dictionary<string, Name> girlsNames)
        {
            // get user input
            Console.Write("Enter names of child or quit to exit:\n> ");
            string input = Console.ReadLine();
            input = input.ToLower();

            // quit when user inputs 'quit' or 'q'
            if (input.Equals("quit".ToLower()) || input.Equals("q".ToLower()))
            {
                return false;
            }

            // display info for boy & girl name
            Output(input, boyNames, "boys");
            Output(input, girlsNames, "girls");
            Console.WriteLine();

            return true;
        }

        private static void Output(string name, Dictionary<string, Name> dict, string gender)
        {
            Name nameInfo = null;
            // name (key) found in dictionary
            if (dict.ContainsKey(name))
            {
                nameInfo = dict[name];
            }

            // capitalize 1st letter of name
            name = name.Substring(0, 1).ToUpper() + name.Substring(1);

            // name (key) not found
            if (nameInfo == null)
            {
                Console.WriteLine("{0} is not ranked among the top 1000 {1} names.", name, gender);
            }
            else  // display where name was found & its rank in list & how many names there were
            {
                Console.WriteLine("{0} is ranked {1} in popularity among {2} with\n  {3} namings.",
                    name, nameInfo.Rank, gender, nameInfo.Count);
            }
        }
    }
}