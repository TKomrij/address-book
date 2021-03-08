using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contactObject)
        {
            try
            {
                Contacts.Add(contactObject.Email, contactObject);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Hey dummy it broke! Contact already added.");
            }
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                return Contacts[email];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("This email address was not found.");
                return null;
            }

        }
    }
}