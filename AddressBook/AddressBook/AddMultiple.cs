using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddMultiple
    {
        public string Firstname;
        public string Lastname;
        public string City;
        public string State;
        public string Zipcode;
        public string PhoneNumber;
        public string email;
        public static List<AddMultiple> People = new List<AddMultiple>();
        public static void NewContact()
        {
            AddMultiple person = new AddMultiple();
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
        public static void AllDetails(AddMultiple person)
        {
            Console.WriteLine("First Name: " + person.Firstname);
            Console.WriteLine("Last Name: " + person.Lastname);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip Code: " + person.Zipcode);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email ID: " + person.email);

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
        public static void MultipleContact()
        {
            Console.Write("Enter Count-How Many contact You want to add?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Press 1 If you want to add a new Contact to the Address Book");
                switch (Console.ReadLine())
                {
                    case "1":
                        NewContact();
                        ListAllContacts();
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