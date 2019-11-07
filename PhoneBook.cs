using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
namespace Phonebook
{
     class PhoneBook
    {
        List<Contact> Contacts = new List<Contact>();
        InputOutputHandler inputoutputhandler = new InputOutputHandler();

        public  void AddContact()
        {
            
             
              Contacts.Add(inputoutputhandler.GetContact());
            

        }

        public  void Display()
        {
            inputoutputhandler.ShowContacts(Contacts);

        }

        public  void DeleteContact()
        {
         Contact contact = new Contact();
         
         Contacts.RemoveAt
            
        }

  

    }

}