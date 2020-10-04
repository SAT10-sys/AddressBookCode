using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookCode
{
    class MultipleAddressBook
    {
        Dictionary<string, AddressBook> addressBooksCollection = new Dictionary<string, AddressBook>();
        public MultipleAddressBook()
        {
            addressBooksCollection = new Dictionary<string, AddressBook>();
        }
        public void InputAddressBook(string name)
        {
            AddressBook addressBook = new AddressBook();
            addressBooksCollection.Add(name, addressBook);
        }
        public AddressBook DisplayAddressBook(string name)
        {
            if (addressBooksCollection.ContainsKey(name))
                return addressBooksCollection[name];
            return null;
        }
    }
}
