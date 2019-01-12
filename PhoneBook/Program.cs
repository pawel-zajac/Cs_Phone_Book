using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        static void Main()
        {
            List<Contact> contactList = new List<Contact>();
            new Book(contactList).StartPhoneBook();
        }
    }
}
