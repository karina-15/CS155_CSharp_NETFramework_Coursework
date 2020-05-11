using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab2_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phoneList = new Dictionary<string, long>();
            String name;
            long phoneNum;
            int choice = 0;
            do
            {
                Console.WriteLine("{0}", "Menu".PadLeft(14, '-').PadRight(24, '-'));
                Console.WriteLine("1. Add to phone list" +
                    "\n2. Remove from phone list" +
                    "\n3. Look up in phone list" +
                    "\n4. Print phone list" +
                    "\n5. Exit");;
                Console.Write("> ");

                // user input
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    choice = default;
                }
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("---Add to phone list---");
                        Console.Write("Enter name:\n> ");
                        name = Console.ReadLine();
                        Console.Write("Enter phone number:\n> ");
                        phoneNum = Convert.ToInt64(Console.ReadLine());
                        phoneList.Add(name, phoneNum);
                        Console.Clear();
                        Console.WriteLine("{0} was added to phone list.\n", name);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("---Remove from phone list---");
                        Console.Write("Enter name to remove:\n> ");
                        name = Console.ReadLine();
                        if (!phoneList.ContainsKey(name))
                        {
                            Console.Clear();
                            Console.WriteLine("{0} is not in phone list\n", name);
                        }
                        else
                        {
                            phoneList.Remove(name);
                            Console.Clear();
                            Console.WriteLine("{0} was removed\n", name);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("---Look up in phone list---");
                        Console.Write("Enter name to look up:\n> ");
                        name = Console.ReadLine();
                        if (phoneList.ContainsKey(name))
                        {
                            Console.Clear();
                            Console.WriteLine("Name: {0}\tPhone#: {1}\n", name, phoneList[name]);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("{0} does not exist in phone list\n", name);
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("{0}", "Phone List".PadLeft(20,'-').PadRight(32, '-'));
                        if(phoneList.Count == 0)
                        {
                            Console.WriteLine("EMPTY\n");
                        }
                        else
                        {
                            Console.WriteLine("{0}|{1}", "Name".PadLeft(11, '-').PadRight(20, '-'),
                                "Phone #".PadLeft(9, '-').PadRight(11, '-'));
                        
                            foreach(KeyValuePair<string, long> kv in phoneList)
                            {
                                Console.WriteLine("{0, -20} {1, -10}", kv.Key, kv.Value);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try Again.\n");
                        break;
                }

            } while (choice != 5);

            Console.ReadKey();  // prevents window from closing
        }
    }
}