using System;
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
                        HandleFinding();
                        break;
                    case "ADD":
                        HandleAdding();
                        break;
                    case "DELETE":
                        HandleDeleting();
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

        public void HandleFinding()
        {
            UserInterface.PrintEnterNameToFindMessage();
            string name = Console.ReadLine().Trim();
            Contact searchResult = Operations.Find(this.contactList, name);

            if (searchResult != null)
            {
                UserInterface.PrintContact(searchResult);
            } else
            {
                UserInterface.PrintNoRecordMessage();
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
                Operations.Add(this.contactList, name, number);
                UserInterface.PrintAddSuccessMessage();
            } else
            {
                UserInterface.PrintIncorrectNumberMessage();
            }
        }

        public void HandleDeleting()
        {
            UserInterface.PrintEnterNameToDeleteMessage();
            string name = Console.ReadLine().Trim();
            Contact searchResult = Operations.Find(this.contactList, name);

            if (searchResult != null)
            {
                Operations.Delete(this.contactList, searchResult);
                UserInterface.PrintDeleteSuccessMessage();
            }
            else
            {
                UserInterface.PrintNoRecordMessage();
            }
        }
    }
}
