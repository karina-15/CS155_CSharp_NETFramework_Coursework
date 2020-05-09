using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1_DocumentInheritance
{
    class DocumentDriver
    {
        static void Main(string[] args)
        {
            Document doc1 = new Document("This is text for my document.");
            Console.WriteLine("Document: " + doc1.ToString());

            Console.WriteLine();

            Email email1 = new Email("Karina", "John", "Test email", doc1.ToString());
            Console.WriteLine("Email:\n" + email1.ToString());

            Console.WriteLine();

            doc1.SetText("This is text that will be saved to a file.");
            File file1 = new File("myFile.txt", doc1.ToString());
            Console.WriteLine(file1.ToString());

            Console.ReadKey();  // prevents window from closing
        }
    }
}
