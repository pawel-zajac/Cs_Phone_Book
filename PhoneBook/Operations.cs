using System;
using System.Collections.Generic;

namespace PhoneBook
{
    static class Operations
    {
        public static void Help()
        {
            UserInterface.PrintAvailableCommands();
        }

        public static Contact Find(List<Contact> contacts, string name)
        {
            foreach (Contact item in contacts)
            {
                if (item.Name.ToUpper().Equals(name.ToUpper())) //Case insensitive
                {
                    return item;
                }
            }
            return null;
        }

        public static void Add(List<Contact> contacts, string name, string number)
        {
            contacts.Add(new Contact(name, number));
        }

        public static void Delete(List<Contact> contacts, Contact contact)
        {
            contacts.Remove(contact);
        }


        public static void Cls()
        {
            Console.Clear();
        }

        public static void Exit()
        {
            System.Environment.Exit(1);
        }

    }
}
