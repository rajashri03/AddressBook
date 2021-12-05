using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class EditEntry
    {
        public string Firstname;
        public string Lastname;
        public string City;
        public string State;
        public string Zipcode;
        public string PhoneNumber;
        public string email;
        public static List<EditEntry> People = new List<EditEntry>();
        public static void NewContact()
        {
            EditEntry person = new EditEntry();
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
        public static void AllDetails(EditEntry person)
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

        public static void Update()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 1 If you want to edit any Contact in the Address Book");
            Console.ResetColor();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the First Name of the Person U want to update");
                    string firstname = Console.ReadLine();
                    EditEntry person = People.Find(x => x.Firstname.ToLower() == firstname.ToLower());
                    if (person == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That person U entered is not found\n");
                        Console.ResetColor();
                        EditEntry.Update();
                    }
                    Console.WriteLine("1)If u want to edit the Firstname");
                    Console.WriteLine("2)If u want to edit the LastName");
                    Console.WriteLine("3)If u want to edit the City");
                    Console.WriteLine("4)If u want to edit the State");
                    Console.WriteLine("5)If u want to edit the Zip Code");
                    Console.WriteLine("6)If u want to edit the Phone Number");
                    Console.WriteLine("7)If u want to edit the Email Id");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter New Firstname; ");
                            person.Firstname = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("First Name: " + person.Firstname);
                            break;
                        case 2:
                            Console.WriteLine("Enter New LastName; ");
                            person.Lastname = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("Last Name: " + person.Lastname);
                            break;

                        case 3:
                            Console.WriteLine("Enter New City: ");
                            person.City = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("City: " + person.City);
                            break;
                        case 4:
                            Console.WriteLine("Enter New State: ");
                            person.State = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("State Name: " + person.State);
                            break;
                        case 5:
                            Console.WriteLine("Enter New ZipCode: ");
                            person.Zipcode = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("ZipCode: " + person.Zipcode);
                            break;
                        case 6:
                            Console.WriteLine("Enter New PhoneNumber: ");
                            person.PhoneNumber = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("PhoneNumber: " + person.PhoneNumber);
                            break;
                        case 7:
                            Console.WriteLine("Enter New Email ID: ");
                            person.email = Console.ReadLine();
                            People.Add(person);
                            Console.WriteLine("Email Id: " + person.email);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;

                    }
                    ListAllContacts();
                    break;
                default:
                    Console.WriteLine("Thanku!!!");
                    break;
            }
        }
    }
}