using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddBookMain
    {
        static void Main()
        {
            Console.WriteLine("WELCOME TO ADDRESS-BOOK PROGRAMME.");
            Console.WriteLine("Enter Address Book name : ");
            string BookName = Console.ReadLine();
            Contacts contacts = new Contacts();
            contacts.AddContact(BookName);
            Console.ReadLine();      
        }
        
    }
}
