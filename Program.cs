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
            int choice;
        
         choice=ShowMenu();// shows the menu and returns the user's choice
         
         while(choice!=4)
         {
         switch(choice)
         {
             case 1 : phonebook.AddContact(); break;
             case 2 : phonebook.Display(); break;
             case 3 : phonebook.DeleteContact(); break;
             case 4 : break;
             default : Console.WriteLine(" You have entered a wrong option, Please Try again");break;
         }
        choice=ShowMenu();//updating in while loop
        }
        }


        public static int ShowMenu()// simple menu
        {
            
             Console.WriteLine(" 1. Add a contact");
           Console.WriteLine(" 2. View all Contacts ");
           Console.WriteLine(" 3. Delete");
           Console.WriteLine(" 4. exit");
           return(Convert.ToInt32(Console.ReadLine()));

        }

        


}
}
