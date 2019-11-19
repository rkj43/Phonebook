using System.Collections.Generic;
namespace Phonebook
{

    
    interface IHandler
    {
        Contact GetContacts();
       void ShowContacts(List<Contact> contacts);
       

        int ShowMenu();


    }

}