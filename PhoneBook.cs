using System;
using System.Collections.Generic;
using System.Collections;
namespace Phonebook
{
    class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();

        public void ReadFromFile()
        {
            FileHandler fileHandler = new FileHandler();

            fileHandler.jsonReader(contacts);
        
        }


        public void AddContact(Contact contact)
        {


            contacts.Add(contact);


        }

      

        public List<Contact> Display()
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

        public void StoreData()
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.jsonWriter(contacts);
        }



    }

}