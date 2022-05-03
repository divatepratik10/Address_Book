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
            Console.WriteLine("What to do ?\nPress 1 : Add Contact\nPress 2 : Edit Contact\nPress 3 : Delete Contact");
            int press = Convert.ToInt32(Console.ReadLine());
            Contacts contacts = new Contacts();
            switch (press)
            {
                case 1:
                    Console.WriteLine("Enter how many contacts you want to add in the Address-Book : ");
                    int HowMany = Convert.ToInt32(Console.ReadLine());
                    for(int i = 1; i <= HowMany; i++)
                    {
                        contacts.AddContact();
                    }
                    //contacts.EditContact();
                    //contacts.DeleteContact();
                    //contacts.EditContact();
                    break;

                case 2:
                    contacts.EditContact();
                    break;

                case 3:
                    contacts.DeleteContact();
                    break;

                default:
                    Console.WriteLine("You have entered a wrong input. Please try Again..");
                    break;
            }
            Console.ReadLine();

        }

    }
}

