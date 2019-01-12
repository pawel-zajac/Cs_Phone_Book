using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
