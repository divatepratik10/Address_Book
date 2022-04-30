using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contacts
    {
        //public string AddressBookName;
        public string FName;
        public string LName;
        public string Address;
        public string City;
        public string State;
        public int ZIP;
        public long Phone;
        public string Email;
        public List<Contacts> ContactList = new List<Contacts>();

        internal Contacts()
        {

        }
        public Contacts(string FName, string LName, string Address, string City, string State, int ZIP, long Phone, string Email)
        {
            //this.AddressBookName = AddressBookName;
            this.FName = FName;
            this.LName = LName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZIP = ZIP;
            this.Phone = Phone;
            this.Email = Email;
        }

        public void AddContact()
        {
            Console.WriteLine("Enter First Name : ");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string LName = Console.ReadLine();
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
            Contacts OBJcontacts = new Contacts(FName,LName,Address,City,State,ZIP,Phone,Email);
            ContactList.Add(OBJcontacts);
            Console.WriteLine("Contact is Added to Address-Book.");
        }

        public void EditContact()
        {
            Console.WriteLine("Enter First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastname = Console.ReadLine();
            bool personFound = false;
            foreach (Contacts item in ContactList)
            {
                if ((((item.FName).ToLower() == firstname.ToLower()) && ((item.LName).ToLower() == lastname.ToLower())))
                {
                    Console.WriteLine("Enter new Address");
                    item.Address = Console.ReadLine();
                    Console.WriteLine("Enter new City");
                    item.City = Console.ReadLine();
                    Console.WriteLine("Enter new State");
                    item.State = Console.ReadLine();
                    Console.WriteLine("Enter new ZIP");
                    item.ZIP = (int)Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new Phone Number");
                    item.Phone = (int)Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter new Email");
                    item.Email = Console.ReadLine();
                    personFound = true;
                    Console.WriteLine("Details have been updated.");
                }
            }
            if (personFound == false)
            {
                Console.WriteLine("Person not found");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            string sName = Console.ReadLine();
            bool personFound = false;
            Contacts personToDelete = new Contacts();
            foreach (Contacts item in ContactList)
            {
                if ((((item.FName).ToLower() == fName.ToLower()) && ((item.LName).ToLower() == sName.ToLower())))
                {
                    personToDelete = item;
                    personFound = true;
                    Console.WriteLine("Person has been Removed from Address-Book Contacts.");
                }
            }
            ContactList.Remove(personToDelete);
            if (personFound == false)
            {
                Console.WriteLine("Person not found");
            }
        }
    }

}
