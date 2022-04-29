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
            Contacts contacts = new Contacts();
            contacts.AddContact();
            Console.ReadLine();      
        }
        
    }
}
