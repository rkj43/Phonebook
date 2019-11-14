using System.Collections.Generic;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
namespace Phonebook
{
    class FileHandler
    {
        public void jsonWriter(List<Contact> Contacts)
        {
            string json = JsonConvert.SerializeObject(Contacts.ToArray());

 
            System.IO.File.WriteAllText(@"D:\phonebook.txt", json);
        }
    }

 }


