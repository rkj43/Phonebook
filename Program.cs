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
            InputOutputHandler inputoutputhandler = new InputOutputHandler();
            int choice;
        
         choice=inputoutputhandler.ShowMenu();;// shows the menu and returns the user's choice
         
         while(choice!=5)
         {
         CallSwitch();
        choice= inputoutputhandler.ShowMenu();//updation in while loop
        }
         void CallSwitch()
        {
            switch(choice)
         {
             case 1 : phonebook.AddContact(inputoutputhandler.GetContacts()); break;
             case 2 : inputoutputhandler.ShowContacts(phonebook.Display()); break;
             case 3 : phonebook.DeleteContact(inputoutputhandler.GetName()); break;
             case 4 : inputoutputhandler.ShowContacts(phonebook.Display(),phonebook.FindContact(inputoutputhandler.GetName()));break;
             case 5 : break;
             default : Console.WriteLine(" You have entered a wrong option, Please Try again");break;
         }
        }
        }



        

        


}
}
