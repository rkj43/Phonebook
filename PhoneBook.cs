using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
namespace Phonebook
{
     class PhoneBook
    {
        List<Contact> Contacts = new List<Contact>();

        
        

        public  void AddContact()
        {
            Contact contact = new Contact();
             Console.WriteLine("Please enter the name of the Person you wish to add to the phonebook");
             contact.name=Console.ReadLine();
             
             Console.WriteLine("Please enter his/her number");
             contact.number= Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Please enter his/her email");
             contact.email=Console.ReadLine();

             Contacts.Add(contact);
            

        }

        public  void Display()
        {
            
           
           
            foreach(  Contact contact in Contacts)
            {
            Console.WriteLine(contact.name);
            Console.WriteLine(contact.email);
            Console.WriteLine(contact.number);
            
            }

            

        }

        public  void DeleteContact()
        {
          /*   string deletekey;

            //deletekey=GetInput(); will implement later
            deletekey="rage";

            foreach(  Contact contact in Contacts)
            {
                if(contact.name==deletekey)
                {
                    Contacts.Remove(contact);
                }
            }
            */

        }

  

    }

}