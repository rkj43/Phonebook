using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
namespace Phonebook
{
     class InputOutputHandler
     {
          public Contact GetContact()
          {
                Contact contact = new Contact();

                Console.WriteLine("Please enter the name of the Person you wish to add to the phonebook");
                contact.name=Console.ReadLine();

                Console.WriteLine("Please enter his/her number");
                contact.number= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter his/her email");
                contact.email=Console.ReadLine();

               return contact;
               
          }

          public void ShowContacts(List<Contact> Contacts)
          {
               foreach (Contact contact in Contacts)
            {

            Console.WriteLine("Name: {0} Email : {1} Number :{2}",contact.name,contact.email,contact.number);
           
            }
          }

          public  int ShowMenu()// simple menu
        {
            
           Console.WriteLine(" 1. Add a contact");
           Console.WriteLine(" 2. View all Contacts ");
           Console.WriteLine(" 3. Delete");
           Console.WriteLine(" 4. exit");
           return(Convert.ToInt32(Console.ReadLine()));

        }



         
     }
}