using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
namespace Phonebook
{
     class PhoneBook
    {
        List<Contact> Contacts = new List<Contact>();
        

        public  void AddContact(Contact contact)
        {
            
             
              Contacts.Add(contact);
            

        }

        public  List<Contact> Display()
        {
            return Contacts;

        }

        public  void DeleteContact()
        {
         
         
         Contacts.RemoveAt(Contacts.FindIndex(0,Contacts.Count,x=>x.name=="rage"));
            
        }

        public void FindContact()
        {

        }

  

    }

}