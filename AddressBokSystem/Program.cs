using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class PersonInfo
    {
        //Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string phoneNumber;
        public string email;
    }
    public class AddressBook
    {
        List<PersonInfo> addressBook;
        public AddressBook()
        {
            addressBook = new List<PersonInfo>();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Welcome to Address Book!");
            int choice;
            do
            {
                Console.WriteLine("Enter Choice:");
                Console.WriteLine("1) Add Contact");
                Console.WriteLine("2) Delete Contact");
                Console.WriteLine("3) Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        break;
                    case 2:

                        break;

                    default:
                        Console.WriteLine("Enter Proper Choice!");
                        break;
                }
            } while (choice != 2);


        }
    }
}
