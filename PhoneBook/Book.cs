﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Book
    {

        private List<Contact> contactList;

        public Book (List<Contact> contactList)
        {
            this.contactList = contactList;
        }

        public void StartPhoneBook()
        {
            UserInterface.PrintWelcomeMessage();
            UserInterface.PrintAvailableCommands();

            while (true)
            {
                ExecuteCommandIfValid(GetCommand());
            }
            

        }

        private string GetCommand()
        {
            return Console.ReadLine().Trim().ToUpper();
        }

        private void ExecuteCommandIfValid(string command)
        {
            if(InputValidation.IsCommandValid(command))
            {
                switch (command)
                {
                    case "HELP":
                        Operations.Help();
                        break;
                    case "FIND":
                        //TODO
                        break;
                    case "ADD":
                        HandleAdding();
                        break;
                    case "DELETE":
                        //TODO
                        break;
                    case "CLS":
                        Operations.Cls();
                        break;
                    case "EXIT":
                        Operations.Exit();
                        break;
                }
            }
            else
            {
                UserInterface.PrintIncorrectCommandMessage();
            }
        }

        public void HandleAdding()
        {
            UserInterface.PrintEnterNameMessage();
            string name = Console.ReadLine().Trim();
            UserInterface.PrintEnterNumberMessage();
            string number = Console.ReadLine().Trim();

            if (InputValidation.IsEnteredNumberValid(number))
            {
                Operations.AddContact(this.contactList, name, number);
                UserInterface.PrintAddSuccessMessage();
            } else
            {
                UserInterface.PrintIncorrectNumberMessage();
            }
        }
    }
}
