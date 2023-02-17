using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Create contcat details\n2:Add new contact\n3:Edit contact");
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
                    addressBook.EditContract("Shivani");
                    addressBook.Display();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}
