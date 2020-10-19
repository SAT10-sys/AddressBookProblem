using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.Linq;

namespace Address_Book_Problem
{
    public class MultipleAddressBook
    {
        Dictionary<string, AddressBookMain> multipleAddressBooks = new Dictionary<string, AddressBookMain>();
        AddressBookMain addressBookMain = new AddressBookMain();
        public MultipleAddressBook()
        {
            multipleAddressBooks = new Dictionary<string, AddressBookMain>();
        }
        public void AddNewAddressBook(string nameOfAddressBook)
        {
            multipleAddressBooks.Add(nameOfAddressBook, addressBookMain);
        }
        public AddressBookMain GetAddressBook(string nameOfAddressBook)
        {
            if (multipleAddressBooks.ContainsKey(nameOfAddressBook))
                return multipleAddressBooks[nameOfAddressBook];
            return null;
        }
    }
}
