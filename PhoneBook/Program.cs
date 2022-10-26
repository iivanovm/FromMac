using System;
using System.Collections.Generic;
using System.Linq;
namespace PhoneBook
{
    class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
        {
           
            

            Console.WriteLine("This console PhoneBook");
            Console.WriteLine("Select option");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact");
            Console.WriteLine("3 View all contact");
            Console.WriteLine("4 View contact for given name contact");
            Console.WriteLine("Press x to exit");
            var phoneBook=new PhoneBook();

            while (true)
            {
                Console.WriteLine("Please select one option");
                var userInput = Console.ReadLine();
              
                switch (userInput)
                {
                    case "1":
                        Console.Write("Input your firstname_:");
                        var firstname = Console.ReadLine();
                        Console.Write("Input your lastname_:");
                        var lastname = Console.ReadLine();
                        Console.Write("Input your phonetype_:");
                        var phonetype = Console.ReadLine();
                        Console.Write("Input your number_:");
                        var number = Console.ReadLine();
                        Console.Write("Input your comment_:");
                        var comment = Console.ReadLine();
                        var newCont = new Contact(firstname, lastname, phonetype, number, comment);
                        phoneBook.AddContact(newCont);
                        break;
                    case "2":
                        Console.Write("Input your number_:");
                        var searchnumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchnumber);

                        break;
                    case "3":
                        phoneBook.ShowAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Name search:");
                        var searchname= Console.ReadLine(); 
                        phoneBook.DisplayMatchContact(searchname);
                        break;
                    case "x":
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Wrong select operation"); break;
                }
            }

        }
    }

}