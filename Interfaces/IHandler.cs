using System.Collections.Generic;
namespace Phonebook
{

    // need to work out what all methods can be put in this interface
    interface IHandler
    {
        
       void ShowContacts(List<Contact> contacts);
        string GetName();

    }

}