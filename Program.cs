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

            phonebook.AddContact(fileHandler.jsonReader());//reading from file for intial.
            
            int choice;

            choice = consoleHandler.ShowMenu(); ;// shows the menu and returns the user's choice

            while (choice != 5)
                {
                    CallSwitch();
                    choice = consoleHandler.ShowMenu();//updation in while loop
                }
            void CallSwitch()
            {
                switch (choice)
                {
                    case 1: phonebook.AddContact(consoleHandler.GetContacts()); break;
                    case 2: consoleHandler.ShowContacts(phonebook.Display()); break;
                    case 3: phonebook.DeleteContact(consoleHandler.GetName()); break;
                    case 4: consoleHandler.ShowContacts(phonebook.Display(), phonebook.FindContact(consoleHandler.GetName())); break;
                    case 5: break;
                    default: Console.WriteLine(" You have entered a wrong option, Please Try again"); break;
                }
            }
            fileHandler.jsonWriter(phonebook.Display());// storing data into file.
        }
    }
}
