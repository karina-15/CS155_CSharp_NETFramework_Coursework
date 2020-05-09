using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1_DocumentInheritance
{
    class Document
    {
        /** Properties **/
        private String Text
        {
            get;
            set;
        }

        /** Constructor **/
        public Document(String _text)
        {
            Text = _text;
        }

        public void SetText(String _text)
        {
            Text = _text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
