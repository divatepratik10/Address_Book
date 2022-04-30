using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ADDRESS-BOOK PROGRAMME.");
            Console.WriteLine("What to do ?\nPress 1 : Add Contact\nPress 2 : Edit Contact");
            int press = Convert.ToInt32(Console.ReadLine());
            Contacts contacts = new Contacts();
            switch (press)
            {
                case 1:
                    contacts.AddContact();
                    //contacts.EditContact();
                    break;

                case 2:
                    contacts.EditContact();
                    break;
            }
            Console.ReadLine();

        }

    }
}

