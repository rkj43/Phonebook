using System;
using System.Collections.Generic;
using System.Collections;


namespace Phonebook
{

    class Program
    {


        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            ConsoleHandler consoleHandler = new ConsoleHandler();
            FileHandler fileHandler = new FileHandler();

            phonebook.addContact(fileHandler.readContactsFromJson());//reading from file for intial.
            
            
            int choice;

            choice = consoleHandler.selectFromMenu(); ;// shows the menu and returns the user's choice

            while (choice != 5)
                {
                    CallSwitch();
                    choice = consoleHandler.selectFromMenu();//updation in while loop
                }
            void CallSwitch()
            {
                switch (choice)
                {
                    case 1: phonebook.addContact(consoleHandler.getContactToCreate()); break;
                    case 2: consoleHandler.showContacts(phonebook.getContacts()); break;
                    case 3: phonebook.deleteContact(consoleHandler.getName()); break;
                    case 4: consoleHandler.showContacts(phonebook.getContacts(), phonebook.findContact(consoleHandler.getName())); break;
                    case 5: break;
                    default: Console.WriteLine(" You have entered a wrong option, Please Try again"); break;
                }

                
            }
             fileHandler.exportAsJson(phonebook.display());// storing data into file.
           
        }
    }
}

 

                
