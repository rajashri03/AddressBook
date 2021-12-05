using AddressBook;
Console.Write("Select Number:\n1)Add Contacts\n2)Edit Contact\n3)Delete Contact\n4)Add Multiple Contacts\n");
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
    case 3:
        DeleteContact.NewContact();
        DeleteContact.ListAllContacts();
        DeleteContact.Delete();
        break;
    case 4:
        AddMultiple.NewContact();
        AddMultiple.ListAllContacts();
        AddMultiple.MultipleContact();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;
}