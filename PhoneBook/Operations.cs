using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    static class Operations
    {
        public static void AddContact (List<Contact> contacts, string name, string number)
        {
            contacts.Add(new Contact(name, number));
        }

        public static void Exit ()
        {
            System.Environment.Exit(1);
        }

    }
}
