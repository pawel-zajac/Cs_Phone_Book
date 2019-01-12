using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class Operations
    {
        public static void Help ()
        {
            UserInterface.PrintAvailableCommands();
        }

        public static Contact Find (List<Contact> contacts, string name)
        {
            foreach (Contact item in contacts)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }
            return null;
        }

        public static void AddContact (List<Contact> contacts, string name, string number)
        {
            contacts.Add(new Contact(name, number));
        }

        public static void Cls()
        {
            Console.Clear();
        }

        public static void Exit ()
        {
            System.Environment.Exit(1);
        }

    }
}
