using System;
using System.Collections.Generic;
using System.Collections;
namespace Phonebook
{
    class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)//adding from console
        {
            contacts.Add(contact);
        }

        public void AddContact(List<Contact> filecontacts)//adding from file
        {
            this.contacts = filecontacts;
        }

        public List<Contact> Display()//lists all contents in the phonebook
        {
            return contacts;

        }

        public void DeleteContact(string name)
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

        public int FindContact(string name)
        {
            int index;
            index = contacts.FindIndex(0, contacts.Count, x => x.name == name);
            return index;
        }
    }

}