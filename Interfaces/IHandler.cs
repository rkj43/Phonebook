using System.Collections.Generic;
namespace Phonebook
{

    // need to work out what all methods can be put in this interface
    interface IDataHandler
    {
        
       void showContacts(List<Contact> contacts);
        string getName();

    }

}