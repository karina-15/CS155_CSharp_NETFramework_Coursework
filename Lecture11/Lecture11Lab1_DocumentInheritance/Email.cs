using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11Lab1_DocumentInheritance
{
    class Email : Document
    {
        private String Sender { get; set; }
        private String Recipient { get; set; }
        private String Title { get; set; }

        public Email(String _sender, String _recipient, String _title, String body) : base(body)
        {
            Sender = _sender;
            Recipient = _recipient;
            Title = _title;
        }

        public override string ToString()
        {
            return String.Format("Sender: {0}\nRecipient: {1}\nTitle: {2}\nBody:\n", Sender, Recipient, Title) + base.ToString();
        }

    }
}
