using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookEntry
    {
        List<Contact> addressBook = new List<Contact>();
        public Contact CreateContact()
        {
            Contact addNew = new Contact();
            Console.Write("Enter Your First Name:");
            addNew.FirstName = Console.ReadLine();
            Console.Write("Enter Your Last Name:");
            addNew.LastName = Console.ReadLine();
            Console.Write("Enter Your City Name:");
            addNew.City = Console.ReadLine();
            Console.Write("Enter Your State Name:");
            addNew.State = Console.ReadLine();
            Console.Write("Enter Your Zipcode:");
            addNew.ZipCode = Console.ReadLine();
            Console.Write("Enter Your Phone Number:");
            addNew.PhoneNumber =Console.ReadLine();
            Console.Write("Enter Your Email:");
            addNew.Email = Console.ReadLine();
            return addNew;
        }
        
    }
}

