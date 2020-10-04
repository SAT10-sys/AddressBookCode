using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookCode
{
    class Contact
    {
        public string firstName, lastName, address, city, state, zipCode, phoneNo, eMail;
        public Contact()
        {
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
            phoneNo = "";
            eMail = "";
        }
        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNo, string eMail)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNo = phoneNo;
            this.eMail = eMail;
        }
    }
}
