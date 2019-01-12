using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class UserInterface
    {

        private static readonly string WelcomeMessage = "Welcome to a digital address book of the 21st century!\n";
        private static readonly string AvailableCommands = "Available commands:\n\t" +
            "Type 'HELP' to get the list of commands available\n\t" +
            "Type 'FIND' to search for a person\n\t" +
            "Type 'ADD' to add a person\n\t" +
            "Type 'DELETE' to delete a person\n\t" +
            "Type 'CLS' to clear screen\n\t" +
            "To exit at any time type 'EXIT' command\n";


        public static void PrintWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(WelcomeMessage);
            Console.ResetColor();
        }

        public static void PrintAvailableCommands()
        {
            Console.WriteLine(AvailableCommands);
        }

    }
}
