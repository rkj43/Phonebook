using System;
using System.Collections.Generic;
using System.Collections;

namespace Phonebook
{
    class Phonebook
    {
        List<Contact> Contacts;

        Contact contact = new Contact();
        

        public static void AddContact()
        {
            Contact.GetData(contact);

        }

        public static void Display()
        {

        }

        public static void DeleteContact()
        {

        }

    }

}