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

        public void jsonReader(List<Contact> Contacts)
        {
      
        
            using (StreamReader reader = new StreamReader(@"D:\phonebook.txt"))
            {
                string json = reader.ReadToEnd();
                Contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
            }
        }           

        }
    }

 


