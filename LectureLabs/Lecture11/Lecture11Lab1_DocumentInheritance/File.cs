using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1_DocumentInheritance
{
    class File : Document
    {
        private String Pathname { get; set; }

        public File(String _pathname, String _text) : base(_text)
        {
            Pathname = _pathname;
        }

        public override string ToString()
        {
            System.IO.File.WriteAllText(
                @"D:\Previous Semesters\2019 Fall\3 - CS 155 - C#-.NET Framework\CS155_CSharp_NETFramework_Coursework\LectureLabs\Lecture11\Lecture11Lab1_DocumentInheritance\"
                + Pathname, base.ToString());
            return "Wrote file " + Pathname;
        }
    }
}
