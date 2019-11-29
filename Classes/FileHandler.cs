using System.Collections.Generic;
using System.Collections;
using System.IO;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Phonebook
{
    class FileHandler
    {
        public void jsonWriter(List<Contact> contacts)
        {
            //string json = JsonConvert.SerializeObject(contacts, Formatting.Indented); ------------>>this also works, just file formatting difference.
            string json = JsonConvert.SerializeObject(contacts.ToArray());
            File.WriteAllText(@"D:\Phonebook\phonebook.json",json);
        }

        public List<Contact>  jsonReader()
        {
           
            string json = File.ReadAllText(@"D:\Phonebook\phonebook.json");
            return(JsonConvert.DeserializeObject<List<Contact>>(json));

            
        }

        public string GetName()
        {
            string name;
            Console.WriteLine("Enter the name of the contact");
            name = Console.ReadLine();
            return name;
        }

       
      

    }
}




