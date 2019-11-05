using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
namespace Phonebook
{
     class PhoneBook
    {
        List<Contact> Contacts = new List<Contact>();

        Contact contact = new Contact();
        

        public  void AddContact()
        {
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
            Console.WriteLine("Hello!");
            for(int i =0; i<Contacts.Count;i++)
            {
            Console.WriteLine(Contacts[i]);
            }

        }

        public  void DeleteContact()
        {

        }

  

    }

}