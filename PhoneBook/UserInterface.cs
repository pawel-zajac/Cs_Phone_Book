using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class UserInterface
    {

        private static readonly string welcomeMessage = "Welcome to a digital address book of the 21st century!\n";
        private static readonly string availableCommands = "Available commands:\n\t" +
            "Type 'HELP' to get the list of commands available\n\t" +
            "Type 'FIND' to search for a person\n\t" +
            "Type 'ADD' to add a person\n\t" +
            "Type 'DELETE' to delete a person\n\t" +
            "Type 'CLS' to clear screen\n\t" +
            "To exit at any time type 'EXIT' command\n";
        private static readonly string incorrectCommandMessage = "Incorrect command.For a list of available commands type 'HELP'.";
        //ADD feature
        private static readonly string enterNameMessage = "Type the name:";
        private static readonly string enterNumberMessage = "Type the phone number:";
        private static readonly string addSuccessMessage = "A new person has been added to the book.";
        private static readonly string incorrectNumberMessage = "Incorrect phone number.";
        



        public static void PrintWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(welcomeMessage);
            Console.ResetColor();
        }

        public static void PrintAvailableCommands()
        {
            Console.WriteLine(availableCommands);
        }

        public static void PrintIncorrectCommandMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(incorrectCommandMessage);
            Console.ResetColor();
        }

        public static void PrintEnterNameMessage()
        {
            Console.WriteLine(enterNameMessage);
        }

        public static void PrintEnterNumberMessage()
        {
            Console.WriteLine(enterNumberMessage);
        }

        public static void PrintAddSuccessMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(addSuccessMessage);
            Console.ResetColor();
        }

        public static void PrintIncorrectNumberMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(incorrectNumberMessage);
            Console.ResetColor();
        }

    }
}
