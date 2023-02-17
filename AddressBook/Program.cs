using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book program");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            addressBook.Display();
        }
    }
}
