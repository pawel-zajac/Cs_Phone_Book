using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contactList = new List<Contact>();
            new Book(contactList).StartPhoneBook();
        }
    }
}
