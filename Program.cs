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
         
         while(choice!=4)
         {
         CallSwitch();
        choice= inputoutputhandler.ShowMenu();
        }
         void CallSwitch()
        {
            switch(choice)
         {
             case 1 : phonebook.AddContact(); break;
             case 2 : phonebook.Display(); break;
             case 3 : phonebook.DeleteContact(); break;
             case 4 : break;
             default : Console.WriteLine(" You have entered a wrong option, Please Try again");break;
         }
        }
        }



        

        


}
}
