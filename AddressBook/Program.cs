﻿using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Create contcat details\n2:Add new contact\n3:Edit contact\n4:Delete contact\n5:Add multiple contact\n6:No duplicate entry\n7:Search person based on city or state\n8:Search person number based on city or state\n9:Store contacts in dictionary\n10:Sort contact by name\n11:Sort contact by city or state or zip\n12:Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBook.CreateContact();
                    addressBook.Display();
                    break;
                case 2:
                    addressBook.CreateContact();
                    addressBook.Display();
                    break;
                case 3:
                    addressBook.CreateContact();
                    addressBook.EditContact("Vaibhav");
                    addressBook.Display();
                    break;
                case 4:
                    addressBook.CreateContact();
                    addressBook.DeleteContact("Vaibhav");
                    addressBook.Display();
                    break;
                case 5:
                    addressBook.CreateContact();
                    addressBook.Display();
                    break;
                case 6:
                    addressBook.CreateContact();
                    addressBook.NoDuplicateEntry("Vaibhav");
                    addressBook.Display();
                    break;
                case 7:
                    addressBook.CreateContact();
                    addressBook.SearchPersonBasedOnCityOrState("Lucknow", "UttarPradesh");
                    addressBook.Display();
                    break;
                case 8:
                    addressBook.CreateContact();
                    addressBook.SearchNumPersonContactBasedOnCityOrState();
                    addressBook.Display();
                    break;
                case 9:
                    contactBook.addContact("Vaibhav", "Mehta", "Kalyanpur", "Lucknow", "Uttarpradesh", 1236, "8983922703", "Vaibhav@gmail.com");
                    contactBook.ShowList();
                    break;
                case 10:
                    contactBook.addContact("Vaibhav", "Mehta", "Kalyanpur", "Lucknow", "UttarPradesh", 1236, "8983922703", "Vaibhav@gmail.com");
                    contactBook.addContact("Hayat", "Mehta", "Vikas Nagar", "Lucknow", "UttarPradesh", 1236, "8983922708", "Hayat@gmail.com");
                    contactBook.SortContactByName();
                    break;
                case 11:
                    contactBook.addContact("Vaibhav", "Mehta", "Kalyanpur", "Lucknow", "UttarPradesh", 4006, "8983922703", "Vaibhav@gmail.com");
                    contactBook.addContact("Hayat", "Mehta", "Vikas Nagar", "Lucknow", "UttarPradesh", 2056, "8983922708", "Hayat@gmail.com");
                    contactBook.SortContactByCity();
                    Console.WriteLine("-------------------");
                    contactBook.SortContactByState();
                    Console.WriteLine("-------------------");
                    contactBook.SortContactByZip();
                    Console.WriteLine("_------------------");
                    break;
                case 12:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}
