using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class InputValidation
    {

        public static bool IsCommandValid(string command)
        {
            string formattedCommand = command.Trim().ToUpper();
            switch (formattedCommand)
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




    }
}
