using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureMidterm
{
    class LectureMidterm
    {
        static void Main(string[] args)
        {
            int[] qArr = new int[3];
            qArr[0] = 7;
            qArr[1] = 7;
            qArr[2] = 6;
            StudentRecord s1 = new StudentRecord(qArr, 88, 75);
            s1.OverallGrade();
            Console.WriteLine(s1.ToString());

            Console.ReadLine();
        }
    }
}
