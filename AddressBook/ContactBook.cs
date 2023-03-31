using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactBook
    {
        public Dictionary<string, Contact> contactDict;
        public Dictionary<int, Contact> contactDict1;
        public Dictionary<string, Contact> contactDict2;
        public List<Contact> contactList;

        public ContactBook()
        {
            this.contactDict = new Dictionary<string, Contact>();
            this.contactDict1 = new Dictionary<int, Contact>();
            this.contactDict2 = new Dictionary<string, Contact>();
            this.contactList = new List<Contact>(contactDict.Values);
            this.contactList = new List<Contact>(contactDict1.Values);
            this.contactList = new List<Contact>(contactDict2.Values);
        }

        public void addContact(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber, string email)
        {
            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            //this.contactDict.Add(firstName, newContact);
            this.contactDict.Add(city, newContact);
            this.contactDict2.Add(state, newContact);
            this.contactDict1.Add(zip, newContact);
        }
        public void ShowList()
        {
            foreach (var contact in contactDict)
            {
                Console.WriteLine("FirstName: " + contact.Value.FirstName);
                Console.WriteLine("LastName: " + contact.Value.LastName);
                Console.WriteLine("Address: " + contact.Value.Address);
                Console.WriteLine("City: " + contact.Value.City);
                Console.WriteLine("State: " + contact.Value.State);
                Console.WriteLine("ZipCode: " + contact.Value.Zip);
                Console.WriteLine("Phone Number: " + contact.Value.PhoneNumber);
                Console.WriteLine("Email: " + contact.Value.Email);
                Console.WriteLine("------------------------------------------");
            }
        }
        public void deleteContact(string fName)
        {
            foreach (var contact in contactDict)
            {
                if (contact.Key == fName)
                {
                    contactDict.Remove(contact.Key);
                    break;
                }
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in contactDict)
            {
                if (contact.Value.Equals(name))
                {
                    Console.WriteLine("Enter option to edit contact");
                    Console.WriteLine("1:First name\n2:Last name\n3:Address\n4:City\n5:State\n6:Phone number\n7:Zip code\n8:Email Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter new First name");
                            contact.Value.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter new last name");
                            contact.Value.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            contact.Value.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            contact.Value.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            contact.Value.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter new phone number");
                            contact.Value.PhoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter zip code");
                            contact.Value.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter new email id");
                            contact.Value.Email = Console.ReadLine();
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
        public void SortContactByName()
        {
            var array = contactDict.Keys.ToArray();
            Array.Sort(array);
            foreach (var ele in array)
            {
                Console.WriteLine(ele);
            }
        }
        public void SortContactByCity()
        {
            var array = contactDict.Keys.ToArray();
            Array.Sort(array);
            foreach (var ele in array)
            {
                Console.WriteLine(ele);
            }
        }
        public void SortContactByState()
        {
            var array = contactDict2.Keys.ToArray();
            Array.Sort(array);
            foreach (var ele in array)
            {
                Console.WriteLine(ele);
            }
        }
        public void SortContactByZip()
        {
            var array = contactDict1.Keys.ToArray();
            Array.Sort(array);
            foreach (var ele in array)
            {
                Console.WriteLine(ele);
            }
        }
    }
}