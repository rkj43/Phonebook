using System;
using System.Collections.Generic;
using System.Collections;


namespace Phonebook
{

    class Program
    {
//test

        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            ConsoleHandler consoleHandler = new ConsoleHandler();
            FileHandler fileHandler = new FileHandler();

            phonebook.addContact(fileHandler.jsonReader());//reading from file for intial.
            
            
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
                    case 1: phonebook.addContact(consoleHandler.getContacts()); break;
                    case 2: consoleHandler.showContacts(phonebook.display()); break;
                    case 3: phonebook.deleteContact(consoleHandler.getName()); break;
                    case 4: consoleHandler.showContacts(phonebook.display(), phonebook.findContact(consoleHandler.getName())); break;
                    case 5: break;
                    default: Console.WriteLine(" You have entered a wrong option, Please Try again"); break;
                }

                
            }
             fileHandler.jsonWriter(phonebook.display());// storing data into file.
           
        }
    }
}

 

                
