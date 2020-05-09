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
            Dictionary<string, Name> boyNames = new Dictionary<string, Name>();
            Dictionary<string, Name> girlNames = new Dictionary<string, Name>();

            using (StreamReader s = new StreamReader("../../boynames.txt"))
            {
                int rank = 0;
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    rank++;
                    string[] words = line.Split(delimiterChars);
                    boyNames.Add(words[0], new Name(Convert.ToInt32(words[1]), rank));
                }
            }
            using (StreamReader s = new StreamReader("../../girlnames.txt"))
            {
                int rank = 0;
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    rank++;
                    string[] words = line.Split(delimiterChars);
                    girlNames.Add(words[0], new Name(Convert.ToInt32(words[1]), rank));
                }
            }

            foreach(KeyValuePair<string, Name> kvp in boyNames)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }
/*            Console.Write("Enter a name: ");
            String nameInput = Console.ReadLine();
            if(!girlNames.ContainsKey(nameInput) && !boyNames.ContainsKey(nameInput))
            {
                Console.WriteLine(String.Format("{0} is not ranked among the top 1000 girl or boy names.", nameInput));
            } else if(girlNames.ContainsKey(nameInput))
            {
                Console.WriteLine(String.Format("{0}", girlNames[nameInput]));
            } else if(boyNames.ContainsKey(nameInput))
            {
                Console.WriteLine(String.Format("{0}", boyNames.Values));
            }*/

            Console.ReadKey();  // prevents window from closing
        }
    }
}
