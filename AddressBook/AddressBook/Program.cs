/*
 * Create Contact in Address Book
 */
using AddressBook;
//Creating object of AddressbookEntry
AddressBookEntry addressBook = new AddressBookEntry(1);
Contact newContact =addressBook.CreateContact();


Console.WriteLine("\n*****-> Details Of Person  <-*****");
Console.WriteLine($"First Name: {newContact.FirstName}");
Console.WriteLine($"Last Name: {newContact.LastName}");
Console.WriteLine($"City Name: {newContact.City}");
Console.WriteLine($"State Name: {newContact.State}");
Console.WriteLine($"Zipcode: {newContact.ZipCode}");
Console.WriteLine($"PhoneNumber: {newContact.PhoneNumber}");
Console.WriteLine($"Email: {newContact.Email}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Address book options:\n add - To Add New Entry.\nquit - TO Leave.\n");
Console.Write("Option: ");
Console.ResetColor();
string Instruction = Console.ReadLine();
while (true)
{
    if (Instruction.ToLower() == "quit")//Checking For Option
    {
        Console.WriteLine("GoodBye!");
        break;
    }
    else if (Instruction.ToLower() == "add")//Checking For Option
    {
        addressBook.AddNewContact();
    }
    else
    {
        Console.WriteLine("Invalid Input!");
    }
}
