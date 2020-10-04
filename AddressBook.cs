using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AddressBookCode
{
    class AddressBook
    {
        List<Contact> list = new List<Contact>();
        public void InputValues()
        {
            string[] details;
            Console.WriteLine(" Enter the following details in order seperated by ,");
            Console.WriteLine(" 1. First Name\n 2. Last Name\n 3. Address\n 4. City\n 5. State\n 6. Zip Code\n 7. Phone Number\n 8. Email ID\n ");
            details = Console.ReadLine().Split(",");
            Contact contact1 = new Contact(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
            list.Add(contact1);
        }
        public void Display()
        {
            foreach(Contact contact1 in list)
            {
                Console.WriteLine(" FIRST NAME: " + contact1.firstName);
                Console.WriteLine(" LAST NAME: " + contact1.lastName);
                Console.WriteLine(" ADDRESS: " + contact1.address);
                Console.WriteLine(" CITY: " + contact1.city);
                Console.WriteLine(" STATE: " + contact1.state);
                Console.WriteLine(" ZIP CODE: " + contact1.zipCode);
                Console.WriteLine(" PHONE NUMBER: " + contact1.phoneNo);
                Console.WriteLine(" EMAIL ID: " + contact1.eMail);
            }
        }
        public int addContact(string firstName)
        {
            string[] details;
            int c = 1;
            foreach(Contact i in list)
            {
                if (i.firstName == firstName)
                {
                    Console.WriteLine(" Enter New Details as follows seperated by ,");
                    Console.WriteLine(" Last Name\n Address\n City\n State\n Zip Code\n Phone Number\n Email ID\n");
                    details = Console.ReadLine().Split(",");
                    i.lastName = details[0];
                    i.address = details[1];
                    i.city = details[2];
                    i.state = details[3];
                    i.zipCode = details[4];
                    i.phoneNo = details[5];
                    i.eMail = details[6];
                }
                else
                    c = 0;
            }
            return c;
        }
        public void RemoveContact(string firstName)
        {
            foreach(Contact i in list)
            {
                if (i.firstName == firstName)
                    list.Remove(i);
            }
        }
    }
}
