//--------------Address--------------//
using AddressBook;
Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new CreateNewContact().Show();
        break;
    case 2:
        EditEntry.NewContact();
        EditEntry.ListAllContacts();
        EditEntry.Update();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;
}