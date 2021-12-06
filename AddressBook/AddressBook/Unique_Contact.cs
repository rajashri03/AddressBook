using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Unique_Contact
    {
        public string Firstname;
        public string Lastname;
        public string City;
        public string State;
        public string Zipcode;
        public string PhoneNumber;
        public string email;
        public static List<Unique_Contact> People = new List<Unique_Contact>();
        public static void NewContact()
        {
            Unique_Contact person = new Unique_Contact();
            Console.Write("Enter First Name: ");
            person.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.Lastname = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.State = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            person.Zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();
            People.Add(person);
        }
        public static void AllDetails(Unique_Contact person)
        {
            Console.WriteLine("First Name: " + person.Firstname);
            Console.WriteLine("Last Name: " + person.Lastname);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip Code: " + person.Zipcode);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email ID: " + person.email);
            Console.WriteLine("*********************************************\n");
        }
        public static void ListAllContacts()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("People in your Address Book:\n");
            Console.ResetColor();
            foreach (var person in People)
            {
                AllDetails(person);
            }

        }
        public static void UniqueContactshow()
        {
            Console.Write("Enter Count-How Many contact You want to add?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
                switch (Console.ReadLine())
                {
                    case "1":
                        for (int j = 0; j < People.Count; j++)
                        {
                            Console.Write("Enter the First Name: ");
                            string fname = Console.ReadLine();
                            if (People[j].Firstname.Equals(fname))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Name already exists\n");
                                Console.ResetColor();
                                Console.ReadKey();
                                Console.WriteLine("\nEnter a New name and Add the details");
                                NewContact();
                                ListAllContacts();
                            }
                            else
                            {
                                NewContact();
                                ListAllContacts();
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("The choice is not valid.");
                        break;
                }
                ListAllContacts();
            }
        }
    }
}