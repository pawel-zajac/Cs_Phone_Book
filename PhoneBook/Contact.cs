﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }
    }

    

    
}
