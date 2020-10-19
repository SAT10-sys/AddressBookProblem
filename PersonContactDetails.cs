using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book_Problem
{
    class PersonContactDetails
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string emailID;
        public PersonContactDetails()
        {
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
            phoneNumber = "";
            emailID = "";
        }
        public PersonContactDetails(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.emailID = emailID;
        }
    }
}

