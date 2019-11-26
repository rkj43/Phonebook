using System.Net.Mail;
using System.Text.RegularExpressions;


namespace Phonebook
{

    class Validations
    {

        public static bool isValidEmail(string inputEmail)
        {
            bool result;
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex regex = new Regex(emailRegex);
            result = (regex.IsMatch(inputEmail)) ? true : false;
            return result;

        }

        public static bool isValidNumber(string number)
        {   
            string numberRegex = @"^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$";
            Regex regex = new Regex(numberRegex);
            bool result;
            
            result = (regex.IsMatch(number)) ? true : false;
            return result;
        }

        public static bool isValidName(string name)
        {   
            string numberRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
            Regex regex = new Regex(numberRegex);
            bool result;
            
            result = (regex.IsMatch(name)) ? true : false;
            return result;
        }

        




    }

}