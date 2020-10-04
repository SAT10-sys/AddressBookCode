using System;
using System.Collections.Generic;

namespace AddressBookCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, address, city, state, zipCode, phoneNo, eMail;
            Console.WriteLine(" Welcome to Address Book Program!!! ");
            Console.WriteLine(" Enter the following details in order");
            Console.WriteLine(" 1. First Name\n 2. Last Name\n 3. Address\n 4. City\n 5. State\n 6. Zip Code\n 7. Phone Number\n 8. Email-ID\n ");
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            address = Console.ReadLine();
            city = Console.ReadLine();
            state = Console.ReadLine();
            zipCode = Console.ReadLine();
            phoneNo = Console.ReadLine();
            eMail = Console.ReadLine();
            Contact contact = new Contact(firstName, lastName, address, city, state, zipCode, phoneNo, eMail);
            contact.DisplayBook();
            AddressBook addressBook = new AddressBook();
            Console.WriteLine(" Welcome to Address Book Program!!! ");
            int num = 1;
            while(num==1)
            {
                List<Contact> list = new List<Contact>();
                Console.WriteLine(" Enter your choice:\n 0. Add Data\n 1. View Data\n 2. Edit Data\n 3. Remove Data\n ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        addressBook.InputValues();
                        Console.WriteLine(" Contact Added ");
                        break;
                    case 1:
                        addressBook.Display();
                        break;
                    case 2:
                        Console.WriteLine(" Enter first name of contact you want to edit ");
                        string first = Console.ReadLine();
                        int checkName = addressBook.addContact(first);
                        if (checkName == 0)
                            Console.WriteLine(" Error. Name not found ");
                        break;
                    case 3:
                        Console.WriteLine(" Enter the first name of the contact to be removed ");
                        first = Console.ReadLine();
                        addressBook.RemoveContact(first);
                        Console.WriteLine(" Contact Removed ");
                        break;
                    default:
                        Console.WriteLine(" Please Enter correct choice 0, 1 or 2"); ;
                        break;
                }
            }
        }
    }
}
