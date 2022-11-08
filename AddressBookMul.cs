using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDictionary
{
    public class AddressBookMul
    {
        //creating String And Int Type Variable To Store Details.
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string emailId;


        //Defining Constructor 
        public AddressBookMul(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string emailId)
        {
            //Set The Class Level Variable Value From The Constructor.
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipcode;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
        }
        public void DisplayContactDettails()
        {
            //printing Details...

            Console.WriteLine("Cntact Details Are....");
            Console.WriteLine("Name:{0} {1}", firstName, lastName);
            Console.WriteLine("Address: {0} ,{1} ({2})", address, city, state);
            Console.WriteLine("Zip Code:{0}", zipCode);
            Console.WriteLine("Phone Number:{0}", phoneNumber);
            Console.WriteLine("Email Id:{0}", emailId);


        }
    }
}
    