using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Claims;
using System.Dynamic;
using System.Linq;
using System.Globalization;

namespace Address_Book_Problem
{
    public class AddressBookMain
    {
        HashSet<PersonContactDetails> set = new HashSet<PersonContactDetails>();
        public void AddContactToBook()
        {
            string[] detailsOfPerson;
            //enter details from user
            Console.WriteLine("Enter the following details seperated by comma");
            Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode, Phone Number, Email ID");
            detailsOfPerson = Console.ReadLine().Split(",");
            PersonContactDetails personContactDetails = new PersonContactDetails(detailsOfPerson[0], detailsOfPerson[1], detailsOfPerson[2], detailsOfPerson[3], detailsOfPerson[4], detailsOfPerson[5], detailsOfPerson[6], detailsOfPerson[7]);
            set.Add(personContactDetails);
            Console.WriteLine("Contact added");
        }
        public void DisplayAddressBook()
        {
            Console.WriteLine("Displaying Contacts");
            foreach (PersonContactDetails contact in set)
            {
                Console.WriteLine("FIRST NAME: " + contact.firstName);
                Console.WriteLine("LAST NAME: " + contact.lastName);
                Console.WriteLine("ADDRESS: " + contact.address);
                Console.WriteLine("CITY: " + contact.city);
                Console.WriteLine("STATE: " + contact.state);
                Console.WriteLine("ZIPCODE: " + contact.zipCode);
                Console.WriteLine("PHONE NUMBER: " + contact.phoneNumber);
                Console.WriteLine("EMAIL ID: " + contact.emailID);
            }
        }
    }
}
