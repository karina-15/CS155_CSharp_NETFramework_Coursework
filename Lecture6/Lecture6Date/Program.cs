using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(1,12,1995);

            //birthday.setMonth(1);
            //birthday.setDay(17);
            //birthday.setYear(1995);

            Console.WriteLine(birthday.MonthString());
            Console.WriteLine(birthday.dateString());

            Date midterm = new Date(10,7,2019);
            Console.WriteLine(midterm.MonthString());
            Console.WriteLine(midterm.dateString());

            Date final = new Date(12,11,2019);
            Console.WriteLine(final.MonthString());
            Console.WriteLine(final.dateString());

            Console.ReadLine();
        }
    }
}
