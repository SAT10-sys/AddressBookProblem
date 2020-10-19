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
            Console.WriteLine("Add new contact");
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
        public void EditUsingFirstName()
        {
            string[] newDetailsOfPerson = new string[8];
            Console.WriteLine("Enter first name of contact you want to edit ");
            string firstName = Console.ReadLine();
            foreach (PersonContactDetails contact in set)
            {
                if (firstName == contact.firstName)
                {
                    Console.WriteLine("Enter new details seperated by comma ");
                    Console.WriteLine("First Name, Last Name, Address, City, State, Zipcode, Phone Number, Email ID");
                    newDetailsOfPerson = Console.ReadLine().Split(",");
                }
                else
                {
                    Console.WriteLine("First Name not found in address book");
                    EditUsingFirstName();
                }
            }
            Console.WriteLine("Edited Details");
            Console.WriteLine("FIRST NAME: " + newDetailsOfPerson[0]);
            Console.WriteLine("LAST NAME: " + newDetailsOfPerson[1]);
            Console.WriteLine("ADDRESS: " + newDetailsOfPerson[2]);
            Console.WriteLine("CITY: " + newDetailsOfPerson[3]);
            Console.WriteLine("STATE: " + newDetailsOfPerson[4]);
            Console.WriteLine("ZIPCODE: " + newDetailsOfPerson[5]);
            Console.WriteLine("PHONE NUMBER: " + newDetailsOfPerson[6]);
            Console.WriteLine("EMAIL ID: " + newDetailsOfPerson[7]);
        }
        public void RemoveUsingFirstName()
        {
            Console.WriteLine("Enter first name of the contact you want to delete");
            string firstName = Console.ReadLine();
            foreach (PersonContactDetails contact in set)
            {
                if (contact.firstName == firstName)
                {
                    set.Remove(contact);
                    Console.WriteLine("Contact removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Name not found in address book");
                    RemoveUsingFirstName();
                }
            }
        }
    }
}
