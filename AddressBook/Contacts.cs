using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contacts
    {
        public string AddressBookName;
        public string FName;
        public string LName;
        public string Address;
        public string City;
        public string State;
        public int ZIP;
        public long Phone;
        public string Email;
        public List<Contacts> ContactList = new List<Contacts>();

        public Contacts()
        {

        }
        public Contacts(string AddressBookName, string FName, string LName, string Address, string City, string State, int ZIP, long Phone, string Email)
        {
            this.AddressBookName = AddressBookName;
            this.FName = FName;
            this.LName = LName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZIP = ZIP;
            this.Phone = Phone;
            this.Email = Email;
        }

        public void AddContact(string AddBook)
        {
            Console.WriteLine("Enter First Name : ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string Lname = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            string City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            string State = Console.ReadLine();
            Console.WriteLine("Enter ZIP code : ");
            int ZIP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number : ");
            int Phone = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email ID : ");
            string Email = Console.ReadLine();
            Contacts OBJcontacts = new Contacts(AddBook,Fname,Lname,Address,City,State,ZIP,Phone,Email);
            ContactList.Add(OBJcontacts);
            Console.WriteLine("Contact is Added to {0} Address-Book.",AddBook);
        }
    }

}
