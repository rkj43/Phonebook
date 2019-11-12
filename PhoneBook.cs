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

        public  void DeleteContact(string name)
        {
         
         try
         {
         Contacts.RemoveAt(Contacts.FindIndex(0,Contacts.Count,x=>x.name==name));
         }
         catch(Exception exception)
         {
             Console.Write(exception);
         }
            
        }

        public int FindContact(string name)
        {
           int index;
           index = Contacts.FindIndex(0,Contacts.Count,x=>x.name==name);
           return index;

        }

  

    }

}