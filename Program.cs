using System;

namespace Address_Book_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program ");
            Console.WriteLine(" =============================== ");
            AddressBookMain addressBookMain = new AddressBookMain();
            Console.WriteLine("Please enter your choice of operation(1 to 4)");
            Console.WriteLine("\n1.ADD CONTACT\n2.EDIT CONTACT USING FIRST NAME\n3.REMOVE CONTACT USING FIRST NAME\n4.DISPLAY BOOK\n");
            int choiceOfOperation = Convert.ToInt32(Console.ReadLine());
        OperationsOnAddressBook:
            switch (choiceOfOperation)
            {
                case 1:
                    addressBookMain.AddContactToBook();
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
                default:
                    Console.WriteLine("Please enter correct choice(1 to 4)");
                    goto OperationsOnAddressBook;
            }
        }
    }
}