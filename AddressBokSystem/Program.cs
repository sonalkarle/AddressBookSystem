﻿using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBook
    {
        //Create dictionary to store result
        Dictionary<String, String> Contactlist = new Dictionary<string, string>();
        private void AddContact()
        {
            Console.WriteLine("first Name:");
            Contactlist.Add("first Name", Console.ReadLine());

            Console.WriteLine("last Name:");
            Contactlist.Add("last Name", Console.ReadLine());

            Console.WriteLine("Address:");
            Contactlist.Add("Address", Console.ReadLine());

            Console.WriteLine("City:");
            Contactlist.Add("City", Console.ReadLine());

            Console.WriteLine("State:");
            Contactlist.Add("State", Console.ReadLine());

            Console.WriteLine("Zip:");
            Contactlist.Add("Zip", Console.ReadLine());

            Console.WriteLine("Phone number:");
            Contactlist.Add("Phone number", Console.ReadLine());

            Console.WriteLine("Email:");
            Contactlist.Add("Email", Console.ReadLine());
        }

        static void Main(string[] args)
        {


            AddressBook addressBook = new AddressBook();
            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1. add contact ");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            addressBook.AddContact();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
    }
}




        


