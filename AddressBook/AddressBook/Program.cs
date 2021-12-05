/*
 * Create Contact in Address Book
 */

using AddressBook;

AddressBookEntry addressBook = new AddressBookEntry();
Contact newContact =addressBook.CreateContact();

Console.WriteLine("\n*****-> Details Of Person  <-*****");
Console.WriteLine($"First Name: {newContact.FirstName}");
Console.WriteLine($"Last Name: {newContact.LastName}");
Console.WriteLine($"City Name: {newContact.City}");
Console.WriteLine($"State Name: {newContact.State}");
Console.WriteLine($"Zipcode: {newContact.ZipCode}");
Console.WriteLine($"PhoneNumber: {newContact.PhoneNumber}");
Console.WriteLine($"Email: {newContact.Email}");

