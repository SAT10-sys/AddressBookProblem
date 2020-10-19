using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

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
        public bool CheckDuplicateName()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (multipleAddressBooks.ContainsKey(firstName))
                return false;
            return true;
        }
        public void SearchPersonByCityStateOverMultipleAddressBook(string cityOrState)
        {
            Dictionary<string, AddressBookMain>.Enumerator enumerator = multipleAddressBooks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("Name Of Address Book: " + enumerator.Current.Key);
                Console.WriteLine();
                enumerator.Current.Value.SearchContactByCityOrState(cityOrState);
                Console.WriteLine("===========================================");
            }
        }
        public Dictionary<string, PersonContactDetails> CityDictionaryCollection()
        {
            Dictionary<string, PersonContactDetails> cityDictionary = new Dictionary<string, PersonContactDetails>();
            Dictionary<string, AddressBookMain>.Enumerator enumerator = multipleAddressBooks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddressBookMain searchAddressBook = enumerator.Current.Value;
                HashSet<PersonContactDetails> addressBook = searchAddressBook.GetAddressBook();
                HashSet<PersonContactDetails>.Enumerator enumerator1 = addressBook.GetEnumerator();
                while (enumerator1.MoveNext())
                {
                    PersonContactDetails c = enumerator1.Current;
                    cityDictionary.Add(enumerator1.Current.city, c);
                }
            }
            return cityDictionary;
        }
        public Dictionary<string, PersonContactDetails> StateDictionaryCollection()
        {
            Dictionary<string, PersonContactDetails> stateDictionary = new Dictionary<string, PersonContactDetails>();
            Dictionary<string, AddressBookMain>.Enumerator enumerator = multipleAddressBooks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                AddressBookMain searchAddressBook = enumerator.Current.Value;
                HashSet<PersonContactDetails> addressBook = searchAddressBook.GetAddressBook();
                HashSet<PersonContactDetails>.Enumerator enumerator1 = addressBook.GetEnumerator();
                while (enumerator1.MoveNext())
                {
                    PersonContactDetails c = enumerator1.Current;
                    stateDictionary.Add(enumerator1.Current.state, c);
                }
            }
            return stateDictionary;
        }
    }
}


