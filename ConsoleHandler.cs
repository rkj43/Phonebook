using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace Phonebook
{
    class ConsoleHandler : IHandler
    {
        public Contact GetContacts()
        {
            Contact contact = new Contact();

            Console.WriteLine("Please enter the  test name of the Person you wish to add to the phonebook");
            contact.name = Console.ReadLine();

            Console.WriteLine("Please enter his/her number");
            contact.number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter his/her email");
            contact.email = Console.ReadLine();
            return contact;

        }

        public void ShowContacts(List<Contact> Contacts)
        {
            foreach (Contact contact in Contacts)
            {

                Console.WriteLine("Name: {0} Email : {1} Number :{2}", contact.name, contact.email, contact.number);

            }
        }

        public void ShowContacts(List<Contact> Contacts, int index)
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

        public string GetName()
        {
            string name;
            Console.WriteLine("Enter the name of the contact");
            name = Console.ReadLine();
            return name;
        }



        public int ShowMenu()// simple menu
        {

            Console.WriteLine(" 1. Add a contact");
            Console.WriteLine(" 2. View all Contacts ");
            Console.WriteLine(" 3. Delete");
            Console.WriteLine(" 4. Find Contact");
            Console.WriteLine(" 5. exit");
            return (Convert.ToInt32(Console.ReadLine()));

        }

        public static bool isValidEmail(string inputEmail)
        {
            bool result;
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(emailRegex);
            result = (regex.IsMatch(inputEmail)) ? true : false;
            return result;

        }





    }
}