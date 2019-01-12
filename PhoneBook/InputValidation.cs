using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhoneBook
{
    static class InputValidation
    {

        public static bool IsCommandValid(string command)
        {
            switch (command)
            {
                case "HELP":
                case "FIND":
                case "ADD":
                case "DELETE":
                case "CLS":
                case "EXIT":
                    return true;
                default:
                    return false;
            }
        }

        //Outside of scope
        public static bool IsNameNotEmpty(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                return true;
            }
            return false;
        }

        //Outside of scope
        public static bool IsNameAvailable(List<Contact> contacts, string name)
        {
            if (Operations.Find(contacts, name) == null)
            {
                return true;
            }
            return false;
        }

        public static bool IsEnteredNumberValid(string number)
        {
            if (!String.IsNullOrEmpty(number) && Regex.Match(number, "^[0-9]*$").Success)
            {
                return true;
            }
            return false;
        }




    }
}
