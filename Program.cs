using System;

namespace Address_Book_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfAddressBook = "";
            int choiceOfOperation;
            int choiceOfAddressBookOperation;
            Console.WriteLine(" Welcome to Address Book Program ");
            Console.WriteLine(" =============================== ");
            AddressBookMain addressBookMain = null;
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            while (true)
            {
                bool flag = true;
                Console.WriteLine("Enter your choice of operation(1 or 2)\n1.ADD ADDRESS BOOK\n2.GET ADDRESS BOOK\n");
                choiceOfOperation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name of Address Book");
                nameOfAddressBook = Console.ReadLine();
                switch (choiceOfOperation)
                {
                    case 1:
                        multipleAddressBook.AddNewAddressBook(nameOfAddressBook);
                        addressBookMain = multipleAddressBook.GetAddressBook(nameOfAddressBook);
                        break;
                    case 2:
                        addressBookMain = multipleAddressBook.GetAddressBook(nameOfAddressBook);
                        if (addressBookMain == null)
                            Console.WriteLine("No such address book found");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                while (flag)
                {
                    if (addressBookMain == null)
                        break;
                    OperationsOnAddressBook:
                    Console.WriteLine("Please enter your choice of operation(1 to 4)");
                    Console.WriteLine("\n1.ADD CONTACT\n2.EDIT CONTACT USING FIRST NAME\n3.REMOVE CONTACT USING FIRST NAME\n4.DISPLAY BOOK\n5.CHECK FOR DUPLICATE NAME\n6.EXIT");
                    choiceOfAddressBookOperation = Convert.ToInt32(Console.ReadLine());
                    switch (choiceOfAddressBookOperation)
                    {
                        case 1:
                            Console.WriteLine("Enter number of contacts you want to add");
                            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= numberOfContacts; i++)
                            {
                                addressBookMain.AddContactToBook();
                            }
                            break;
                        case 2:
                            addressBookMain.EditUsingFirstName();
                            break;
                        case 3:
                            addressBookMain.RemoveUsingFirstName();
                            break;
                        case 4:
                            addressBookMain.DisplayAddressBook();
                            break;
                        case 5:
                            multipleAddressBook.CheckDuplicateName();
                            break;
                        case 6:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Please enter valid choice");
                            goto OperationsOnAddressBook;
                    }
                }
            }
        }
    }
}