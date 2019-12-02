using System;
using System.Collections.Generic;
using System.Collections;
namespace Phonebook
{
    class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();

        public void addContact(Contact contact)//adding from console
        {
            contacts.Add(contact);
        }

        public void addContact(List<Contact> contactsToAdd)//adding from file
        {
            this.contacts = contactsToAdd;
        }

        public List<Contact> getContacts()//lists all contents in the phonebook
        {
            return contacts;

        }

        public void deleteContact(string name)
        {

            try
            {
                contacts.RemoveAt(contacts.FindIndex(0, contacts.Count, x => x.name == name));
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }

        public int findContact(string name)
        {
            int index;
            index = contacts.FindIndex(0, contacts.Count, x => x.name == name);
            return index;
        }
    }

}