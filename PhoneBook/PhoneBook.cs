using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        private List<Contact> PhoneBooks { get; set; } = new List<Contact>();

        private void DisplayDetails(Contact contact)
        {
            ConsoleTableFormat.PrintSeparatorLine();
            ConsoleTableFormat.PrintRow("FirstName", "LastName", "PhoneType", "PhoneNumber");
            ConsoleTableFormat.PrintSeparatorLine();
            ConsoleTableFormat.PrintRow(contact.firstname,contact.lastname,contact.phonetype,contact.number);
            ConsoleTableFormat.PrintSeparatorLine();

        }
        private void DisplaContactsDetails(List<Contact> PhoneBooks)
        {
            foreach (var contact in PhoneBooks)
            {
                DisplayDetails(contact);
            }
        }
        public void AddContact(Contact contact)
        {
            PhoneBooks.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = PhoneBooks.FirstOrDefault(x => x.number.ToLower() == number.ToLower());
            if (contact == null)
            {
                Console.WriteLine("Not found in your phone book");
            }
            else
            {
                DisplayDetails(contact);
            }
        }

        public void ShowAllContacts()
        {
            DisplaContactsDetails(PhoneBooks);
        }

        public void DisplayMatchContact(string searchPhrase)
        {
            var matchingContact = PhoneBooks.Where(x => x.firstname.Contains(searchPhrase)).ToList();
            DisplaContactsDetails(matchingContact);
        }
    }
}

