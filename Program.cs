using System;
using System.Collections.Generic;

namespace Address_Book_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfAddressBook = "";
            int choiceOfOperation;
            int choiceOfAddressBookOperation;
            int numberOfCities = 0;
            int numberOFStates = 0;
            Console.WriteLine(" Welcome to Address Book Program ");
            Console.WriteLine(" =============================== ");
            AddressBookMain addressBookMain = null;
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            while (true)
            {
                StartAddressBook:
                bool flag = true;
                Console.WriteLine("Enter your choice of operation(1 to 5)\n1.ADD ADDRESS BOOK\n2.GET ADDRESS BOOK\n3.VIEW PERSON BY CITY\n4.VIEW PERSON BY STATE\n5.EXIT");
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
                    case 3:
                        citySearch:
                        Console.WriteLine("Enter city name whose person details you want");
                        string nameOfCity = Console.ReadLine();
                        Dictionary<string, PersonContactDetails> cityDictionary = multipleAddressBook.CityDictionaryCollection();
                        foreach (var dict in cityDictionary)
                        {
                            if (cityDictionary.ContainsKey(nameOfCity))
                            {
                                Console.WriteLine("First Name:" + dict.Value.firstName + "Last Name:" + dict.Value.lastName + "Address:" + dict.Value.address + "City:" + dict.Value.city + "State:" + dict.Value.state + "pincode:" + dict.Value.zipCode + "phone: " + dict.Value.phoneNumber + "email address:" + dict.Value.emailID + "\n");
                            }
                            else
                            {
                                Console.WriteLine("City doesn't exist");
                                goto citySearch;
                            }
                            numberOfCities++;
                        }
                        Console.WriteLine("Total number of cities in address book: "+numberOfCities);
                        break;
                    case 4:
                        stateSearch:
                        Console.WriteLine("Enter state name whose person details you want");
                        string stateRequired = Console.ReadLine();
                        Dictionary<string, PersonContactDetails> stateDictionary = multipleAddressBook.StateDictionaryCollection();
                        foreach (var dict in stateDictionary)
                        {
                            if (stateDictionary.ContainsKey(stateRequired))
                            {
                                Console.WriteLine("First Name:" + dict.Value.firstName + "Last Name:" + dict.Value.lastName + "Address:" + dict.Value.address + "City:" + dict.Value.city + "State:" + dict.Value.state + "pincode:" + dict.Value.zipCode + "phone: " + dict.Value.phoneNumber + "email address:" + dict.Value.emailID + "\n");
                            }
                            else
                            {
                                Console.WriteLine("State doesn't exist");
                                goto stateSearch;
                            }
                            numberOFStates++;
                        }
                        Console.WriteLine("Total number of states in address book: "+numberOFStates);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        goto StartAddressBook;
                }
                while (flag)
                {
                    if (addressBookMain == null)
                        break;
                    OperationsOnAddressBook:
                    Console.WriteLine("Please enter your choice of operation(1 to 8)");
                    Console.WriteLine("\n1.ADD CONTACT\n2.EDIT CONTACT USING FIRST NAME\n3.REMOVE CONTACT USING FIRST NAME\n4.DISPLAY BOOK\n5.CHECK FOR DUPLICATE NAME\n6.SEARCH CONTACT BY CITY OR STATE\n7.SORT ALPHABETICALLY BY FIRST NAME\n8.SORT BY CITY, STATE AND ZIPCODE\n9.EXIT");
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
                            Console.WriteLine("Enter the city/state");
                            string cityOrState = Console.ReadLine();
                            multipleAddressBook.SearchPersonByCityStateOverMultipleAddressBook(cityOrState);
                            break;
                        case 7:
                            addressBookMain.SortByName();
                            goto OperationsOnAddressBook;
                        case 8:
                            addressBookMain.SortByCityStateZip();
                            goto OperationsOnAddressBook;
                        case 9:
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