using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string phoneNumber;
        private int zip;
        private string email;
        public Contact()
        {

        }

        public Contact(string firstName, string lastName, string address, string city, string state, int zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Zip { get => zip; set => zip = value; }
        public string Email { get => email; set => email = value; }
    }
}
