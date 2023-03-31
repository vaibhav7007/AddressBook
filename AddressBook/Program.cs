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
            Console.WriteLine("1:Create contcat details\n2:Add new contact\n3:Edit contact\n4:Delete contact\n5:Add multiple contact\n6:No duplicate entry\n7:Search person based on city or state\n8:Search person number based on city or state\n9:Exit");
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
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}
