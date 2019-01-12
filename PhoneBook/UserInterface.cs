using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class UserInterface
    {

        //CORE strings
        private static readonly string welcomeMessage = "Welcome to a digital address book of the 21st century!\n";
        private static readonly string availableCommands = "Available commands:\n\t" +
            "Type 'HELP' to get the list of commands available\n\t" +
            "Type 'FIND' to search for a person\n\t" +
            "Type 'ADD' to add a person\n\t" +
            "Type 'DELETE' to delete a person\n\t" +
            "Type 'CLS' to clear screen\n\t" +
            "To exit at any time type 'EXIT' command\n";
        private static readonly string incorrectCommandMessage = "Incorrect command.For a list of available commands type 'HELP'.";
        private static readonly string noRecordMessage = "No such record exists in the book.";

        //FIND feature strings
        private static readonly string enterNameToFindMessage = "Type the name of a contact you want to look up.";
        
        //ADD feature strings
        private static readonly string enterNameMessage = "Type the name:";
        private static readonly string enterNumberMessage = "Type the phone number:";
        private static readonly string addSuccessMessage = "A new person has been added to the book.";
        private static readonly string incorrectNumberMessage = "Incorrect phone number.";

        //DELETE feature strings
        private static readonly string enterNameToDeleteMessage = "Type the name of a contact you want to delete.";
        private static readonly string deleteSuccessMessage = "Entry has been deleted.";


        //CORE methods
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(incorrectCommandMessage);
            Console.ResetColor();
        }

        public static void PrintNoRecordMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(noRecordMessage);
            Console.ResetColor();
        }

        //FIND feature methods
        public static void PrintEnterNameToFindMessage()
        {
            Console.WriteLine(enterNameToFindMessage);
        }

        public static void PrintContact(Contact contact)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Contact name:   {contact.Name}\nContact phone:  {contact.Number}");
            Console.ResetColor();
        }

        //ADD feature methods
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(incorrectNumberMessage);
            Console.ResetColor();
        }

        //DELETE feature methods
        public static void PrintEnterNameToDeleteMessage()
        {
            Console.WriteLine(enterNameToDeleteMessage);
        }

        public static void PrintDeleteSuccessMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(deleteSuccessMessage);
            Console.ResetColor();
        }

    }
}
