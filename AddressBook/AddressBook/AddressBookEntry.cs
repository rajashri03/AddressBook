using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookEntry
    {
        private Contact[] entries;//Class With Array of object
        private int totalEntries = 0;
        public int Size { get; private set; }

        public AddressBookEntry(int size)//Parameterized Constructor 
        {
            entries = new Contact[size];//It will Create an Array
            Size = size;
        }
        List<Contact> addressBook = new List<Contact>();//Creating List of Objects
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
            addNew.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Your Email:");
            addNew.Email = Console.ReadLine();
            return addNew;
        }

        public void AddNewContact()
        {
            Contact newContact = CreateContact();
            addressBook.Add(newContact);
            if (totalEntries < entries.Length)
            {
                entries[totalEntries++] = newContact;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added successfuly!");
                Console.ResetColor();

                Console.WriteLine("\n*****-> Details Of Person  <-*****");
                Console.WriteLine($"First Name: {newContact.FirstName}");
                Console.WriteLine($"Last Name: {newContact.LastName}");
                Console.WriteLine($"City Name: {newContact.City}");
                Console.WriteLine($"State Name: {newContact.State}");
                Console.WriteLine($"Zipcode: {newContact.ZipCode}");
                Console.WriteLine($"Phone Number: {newContact.PhoneNumber}");
                Console.WriteLine($"Email: {newContact.Email}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Address Book is already full.");
                Console.ResetColor();

            }

                

        }
    }
}

