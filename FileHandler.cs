using System.Collections.Generic;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Phonebook
{
    class FileHandler
    {
        public void jsonWriter(List<Contact> contacts)
        {
            //string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            string json = JsonConvert.SerializeObject(contacts.ToArray());
            File.AppendAllText(@"D:\phonebook.json",json);


         //   StreamWriter streamWriter = new StreamWriter(@"D:\phonebook.json");
         //   streamWriter.WriteLine(json);
        }

        public void jsonReader(List<Contact> contacts)
        {
           using (StreamReader file = File.OpenText((@"D:\phonebook.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                contacts = (List<Contact>)serializer.Deserialize(file, typeof(List<Contact>));
            }
            
            
        }

    }
}




