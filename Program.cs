using System;
using System.Collections.Generic;
using System.Collections;

namespace Phonebook
{
      
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("~~~PhoneBook~~~");

         
         
          Dictionary<string, string> phonebook = new Dictionary<string, string>();//create the phonebook dictionary
          
        
         choice=ShowMenu();// shows the menu and returns the user's choice
         while(choice!=4)
         {
         switch(choice)
         {
             case 1 : AddContact(phonebook); break;
             case 2 : PrintPhoneBook(phonebook); break;
             case 3 : DeleteContact(phonebook); break;
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

        public static void AddContact(Dictionary<string,string> phonebook)
        {
            
            string name,number;
             Console.WriteLine("Please enter the name of the Person you wish to add to the phonebook");
             name=Console.ReadLine();
             Console.WriteLine("Please enter his/her number");
             number=Console.ReadLine();
            phonebook.Add(name,number);
            



        }

        public static void DeleteContact(Dictionary<string,string> phonebook)
        {
            string name;
             Console.WriteLine("Please enter the name of the Person you wish to delete from the phonebook");
             name=Console.ReadLine();

             if((phonebook.ContainsKey(name))==true)
             {
                 phonebook.Remove(name);
             }
             else
             {
                 Console.WriteLine("Name does not exist in Phonebook");
             }
            

        }

       

        public static void PrintPhoneBook(Dictionary<string,string> phonebook)
        {
            foreach (KeyValuePair<string, string> item in phonebook)
{
    Console.WriteLine("Name: {0}, Number: {1}", item.Key, item.Value);
}
 
        }

    }
}
