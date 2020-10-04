using System;
using System.Collections.Generic;

namespace AddressBookCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine(" Welcome to Address Book Program!!! ");
            int num = 1;
            while(num==1)
            {
                List<Contact> list = new List<Contact>();
                Console.WriteLine(" Enter your choice:\n 0. Add Data\n 1. View Data\n 2. Edit Data\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        addressBook.InputValues();
                        break;
                    case 1:
                        addressBook.Display();
                        break;
                    case 2:
                        Console.WriteLine(" Enter first name of contact you want to edit ");
                        string firstName = Console.ReadLine();
                        int checkName = addressBook.addContact(firstName);
                        if (checkName == 0)
                            Console.WriteLine(" Error. Name not found ");
                        break;
                    default:
                        Console.WriteLine(" Please Enter correct choice 0, 1 or 2"); ;
                        break;
                }
            }
        }
    }
}
