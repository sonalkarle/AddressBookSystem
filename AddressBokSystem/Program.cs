using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookSystem
    {
        //Generated dictionary for storing
        Dictionary<String, String> Contactlist;
        Dictionary<String, Dictionary<String, String>> AddressBook = new Dictionary<string, Dictionary<String, String>>();
        private void AddContact()
        {
            //Adding contact to the list
            Console.WriteLine("add contact");
            Contactlist = new Dictionary<string, string>();

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
            Contactlist.TryGetValue("First Name", out String FirstName);
            Contactlist.TryGetValue("Last Name", out String LastName);
            AddressBook.Add(FirstName + " " + LastName, Contactlist);
            Console.WriteLine("contact added\n");
        }
        private void ViewContact()
        {
            //Check contact exist or not
            Console.WriteLine("Enter full name:");
            String ContactName = Console.ReadLine();
            if (AddressBook.ContainsKey(ContactName))
            {
                Contactlist = new Dictionary<string, string>();
                AddressBook.TryGetValue(ContactName, out Contactlist);
                Console.WriteLine("First Name: " + Contactlist["first Name"]);

                Console.WriteLine("Last Name:" + Contactlist["last Name"]);

               
            }
            else
                Console.WriteLine("Contact doesn't exist");

        }
        private void EditContact()
        {
            //Edit information
            Console.WriteLine("Enter full contact name");
            String ContactName = Console.ReadLine();

            if (AddressBook.ContainsKey(ContactName))
            {
                Console.WriteLine("enter choice");
                Console.WriteLine("1. First Name    2. Last Name    3. Address ");
                Console.WriteLine("4. City          5. State        6. Zip");
                Console.WriteLine("7. Phone number  8. Email");

                int Choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter contact field:");
                String Cotanctinfo = Console.ReadLine();

                switch (Choice)
                {
                    case 1:
                        AddressBook[ContactName]["First Name"] = Cotanctinfo;
                        break;
                    case 2:
                        AddressBook[ContactName]["Last Name"] = Cotanctinfo;
                        break;
                    case 3:
                        AddressBook[ContactName]["Address"] = Cotanctinfo;
                        break;
                    case 4:
                        AddressBook[ContactName]["City"] = Cotanctinfo;
                        break;
                    case 5:
                        AddressBook[ContactName]["State"] = Cotanctinfo;
                        break;
                    case 6:
                        AddressBook[ContactName]["Zip"] = Cotanctinfo;
                        break;
                    case 7:
                        AddressBook[ContactName]["Phone number"] = Cotanctinfo;
                        break;
                    case 8:
                        AddressBook[ContactName]["Email"] = Cotanctinfo;
                        break;

                }
            }
            else
                Console.WriteLine("contact doesn't exist");

        }
        static void Main(string[] args)
        {
           
            AddressBookSystem addressBook = new AddressBookSystem();

            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1. add contact   2. edit contact");
                Console.WriteLine("3. view contact");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            addressBook.AddContact();
                            break;
                        case 2:
                            addressBook.EditContact();
                            break;
                        case 3:
                            addressBook.ViewContact();
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







