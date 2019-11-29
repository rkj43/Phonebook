using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace Phonebook
{
    class ConsoleHandler : IHandler
    {
        public Contact getContacts()
        {
            Contact contact = new Contact();
            Validations validation = new Validations();

            Console.WriteLine("Please enter the  test name of the Person you wish to add to the phonebook");
            contact.name = Console.ReadLine();
            
            Console.WriteLine("Please enter his/her number");
            contact.number = Console.ReadLine();

            Console.WriteLine("Please enter his/her email");
            contact.email = Console.ReadLine();

            if((validation.isValidNumber(contact.number) == true &&
            (validation.isValidEmail(contact.email)) == true &&
            (validation.isValidName(contact.name))==true))
            {
            return contact;
            }

            else
            {
                Console.WriteLine("You entered wrong data, There was an error while validating the data you have entered . Please check and try again");
                 Contact dummycontact= new Contact();
                 return dummycontact;
            }
        }

        public void showContacts(List<Contact> Contacts)
        {
            foreach (Contact contact in Contacts)
            {

                Console.WriteLine("Name: {0} Email : {1} Number :{2}", contact.name, contact.email, contact.number);

            }
        }

        public void showContacts(List<Contact> Contacts, int index)// polymorphism 
        {
            if (index == -1)
            {
                Console.WriteLine("The contact you have searched for does not exist in this PhoneBook, please try again");
            }
            else
            {
                Console.WriteLine("The contact has been found at index number : {0}", index);
                Console.WriteLine("Name: {0} Email : {1} Number :{2}", Contacts[index].name, Contacts[index].email, Contacts[index].number);
            }
        }

        public string getName()
        {
            string name;
            Console.WriteLine("Enter the name of the contact");
            name = Console.ReadLine();
            return name;
        }



        public int selectFromMenu()// simple menu
        {

            Console.WriteLine(" 1. Add a contact");
            Console.WriteLine(" 2. View all Contacts ");
            Console.WriteLine(" 3. Delete");
            Console.WriteLine(" 4. Find Contact");
            Console.WriteLine(" 5. exit");
            return (Convert.ToInt32(Console.ReadLine()));

        }

       




    }
}