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
                Console.WriteLine("---Menu---\n1. Add to phone list" +
                    "\n2. Remove from phone list" +
                    "\n3. Look up in phone list" +
                    "\n4. Print phone list" +
                    "\n5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter phone number: ");
                        phoneNum = Convert.ToInt64(Console.ReadLine());
                        phoneList.Add(name, phoneNum);
                        break;
                    case 2:
                        Console.WriteLine("Enter name to remove: ");
                        name = Console.ReadLine();
                        if (!phoneList.ContainsKey(name))
                        {
                            Console.WriteLine("Name is not in phone list");
                        }
                        else
                        {
                            phoneList.Remove(name);
                            Console.WriteLine("{0} was removed", name);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter name to look up: ");
                        name = Console.ReadLine();
                        if (phoneList.ContainsKey(name))
                        {
                            Console.WriteLine("Name: {0}\tPhone#: {1}", name, phoneList[name]);
                        }
                        else
                        {
                            Console.WriteLine("Name does not exist in phone list");
                        }
                        break;
                    case 4:
                        Console.WriteLine("---Phone List---");
                        foreach(KeyValuePair<string, long> kv in phoneList)
                        {
                            Console.WriteLine("Name: {0}\tPhone#: {1}", kv.Key, kv.Value);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        break;
                }

            } while (choice != 5);

            Console.ReadKey();  // prevents window from closing
        }
    }
}