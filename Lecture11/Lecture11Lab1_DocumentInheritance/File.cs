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
            System.IO.File.WriteAllText(@"C:\Users\Karina\source\repos\MiraCostaCS113\eliask\Lecture11\" + Pathname, base.ToString());
            return "Wrote file " + Pathname;
        }
    }
}
