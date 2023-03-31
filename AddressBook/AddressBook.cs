using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Please add contact details");
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter zip code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            contact.Email = Console.ReadLine();
            contactList.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Contact Details" + "\n" + "FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Zip: " + contact.Zip + "\n" + "Email: " + contact.Email);
        }
        public void EditContact(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter option to edit contact");
                    Console.WriteLine("1:First name\n2:Last name\n3:Address\n4:City\n5:State\n6:Phone number\n7:Zip code\n8:Email Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new First name");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter new last name");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter new phone number");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter zip code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter new email id");
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Please chosse correct option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The contact is not found");
                }
            }
        }
        public void DeleteContact(string name)
        {
            Contact deleteContact = new Contact();
            foreach (var contact in contactList.ToList())
            {
                if (contact.FirstName.Equals(name))
                {
                    deleteContact = contact;
                }
                contactList.Remove(deleteContact);
            }
            Console.WriteLine("The contact is deleted successfully");
        }
        public void NoDuplicateEntry(string name)
        {
            Contact contact = new Contact();
            if (contactList.Count > 0)
            {
                List<Contact> contacts = contactList.Where(c => c.FirstName == name).ToList();
                if (contacts.Count > 0)
                {
                    Console.WriteLine("Duplicate Entry");
                }
                else
                {
                    contactList.Add(contact);
                }
            }
            else
            {
                contactList.Add(contact);
            }
        }
    }
}
