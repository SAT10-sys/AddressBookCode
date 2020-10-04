using System;

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
        }
    }
}
