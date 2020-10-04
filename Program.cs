
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace AddressBookCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int choice = 0;
            string[] details;
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            AddressBook addressBook = null;
            Console.WriteLine(" Welcome to Address Book Program ");
            while (true)
            {
                bool flag = true;
                Console.WriteLine("\n 1. Add Address Book\n 2. Open Address Book ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Enter name of address book ");
                name = Console.ReadLine();
                if (choice == 1)
                {
                    multipleAddressBook.InputAddressBook(name);
                    addressBook = multipleAddressBook.DisplayAddressBook(name);
                }
                else if (choice == 2)
                {
                    addressBook = multipleAddressBook.DisplayAddressBook(name);
                    if (addressBook == null)
                        Console.WriteLine(" No such Address Book exists ");
                }
                else
                    Console.WriteLine(" Error. Invalid choice ");
                while (flag)
                {
                    if (addressBook == null)
                        break;
                    Console.WriteLine("\n 1. Add Contact\n 2. Edit Contact\n 3. Remove Contact\n 4. Exit\n ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(" Enter the following details seperated by ,");
                            Console.WriteLine(" 1. First Name\n 2. Last Name\n 3. Address\n 4. City\n 5. State\n 6. Zip Code\n 7. Phone Number\n 8. Email ID\n ");
                            details = Console.ReadLine().Split(",");
                            addressBook.InputValues(details[0], details[1], details[2], details[3], details[4], details[5], details[6], details[7]);
                            Console.WriteLine(" Details Added ");
                            break;
                        case 2:
                            Console.WriteLine(" Enter the name to edit ");
                            name = Console.ReadLine();
                            if (addressBook.checkName(name) == true)
                            {
                                Console.WriteLine(" Enter the following details seperated by ,");
                                Console.WriteLine(" 1. Last Name\n 2. Address\n 3. City\n 4. State\n 5. Zip Code\n 6. Phone Number\n 7. Email ID\n ");
                                details = Console.ReadLine().Split(",");
                                addressBook.Display(name, details[0], details[1], details[2], details[3], details[4], details[5], details[6]);
                                Console.WriteLine(" Details edited successfully ");
                            }
                            else
                                Console.WriteLine(" No such contact found ");
                            break;
                        case 3:
                            Console.WriteLine(" Enter the names to be removed ");
                            name = Console.ReadLine();
                            if (addressBook.checkName(name) == true)
                            {
                                addressBook.RemoveContact(name);
                                Console.WriteLine(" Contact removed successfully ");
                            }
                            else
                                Console.WriteLine(" No such contact found ");
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}