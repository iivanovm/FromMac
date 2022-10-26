using System;
using System.Collections.Generic;
using System.Linq;
namespace PhoneBook
{
    class Contact
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phonetype { get; set; }
        public string number { get; set; }
        public string comment { get; set; }

        public Contact(string firstname, string lastname, string phonetype, string number, string commnet)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonetype = phonetype;
            this.number = number;
            this.comment = commnet;
        }

    }
}
