using System;
using System.Collections.Generic;
using System.Collections;

namespace Phonebook
{
    class Contact
    {


        string name;
        double number;

        public static void GetData(Contact contact)
        {
            Console.WriteLine("Please enter the name of the Person you wish to add to the phonebook");
             contact.name=Console.ReadLine();
             Console.WriteLine("Please enter his/her number");
             contact.number= Convert.ToDouble(Console.ReadLine());

        }

        public static void DeleteData()
            {

            }

            public static void PrintConsole(Contact contact)
            {
                
            

            }
        )


    }
}