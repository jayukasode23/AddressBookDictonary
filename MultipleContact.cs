using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDictionary
{
    public class MultipleContact
    {
        // Here, Creating New List To Add Data Information.
        public List<AddressBookMul> AddressList;

        public Dictionary<string, List<AddressBookMul>> myDict = new Dictionary<string, List<AddressBookMul>>();

        public MultipleContact()
        {
            AddressList = new List<AddressBookMul>();
        }
        //Here,Adding New Contact By Using Method.
        public void AddMultipleNewContact()
        {
            //Here,Taking Details (Contact Details)From User To Add In Address Book.
            Console.WriteLine("Fill The Details Given Below: ");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address:");
            string address = Console.ReadLine();
            Console.Write("City:");
            string city = Console.ReadLine();
            Console.Write("State:");
            string state = Console.ReadLine();
            Console.Write("Zip Code: ");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone Number :");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email Adress : ");
            string emailId = Console.ReadLine();

            //Creating Instance And Passing Parameter.
            AddressBookMul addressdetails = new AddressBookMul(firstName, lastName, address, city, state, zipCode, phonenumber, emailId);

            //Here,Defining Logic With The Help Of  If Else To Check Contact Details Present Or Not, If Not Then Add Contact Details.
            int CheckDetails = 0;
            if (AddressList.Count > 0) //Count The Address Present In Address Book.
            {
                foreach (AddressBookMul Address in AddressList)
                {


                    if (Address.city == city && Address.state == state)
                    {
                        CheckDetails = 1;//Check Present Or Not If Present Then Assign Check Details Is 1.
                        Console.WriteLine("Name: {0} {1}", Address.city, Address.state);

                    }
                }
            }
            //if-else to check, The details are  present or not, if present go to if block or go to else block.
            if (CheckDetails == 1)
            {
                Console.WriteLine("The City Or State You Enter Is Already Present In Address Book");
            }
            else
            {
                AddressList.Add(addressdetails);//Add Details in Address Book.
            }
        }
        //Defining Method To Display contact Details After Add New Contact By user.
        public void DisplayContactDetails()
        {
            if (AddressList.Count > 0)
                foreach (AddressBookMul address in AddressList)
                {
                    //printing Details...

                    Console.WriteLine("Contact Details Are....");
                    Console.WriteLine("Name:{0} {1}", address.firstName, address.lastName);
                    Console.WriteLine("Address: {0} ,{1} ({2})", address.address, address.city, address.state);
                    Console.WriteLine("Zip Code:{0}", address.zipCode);
                    Console.WriteLine("Phone Number:{0}", address.phoneNumber);
                    Console.WriteLine("Email Id:{0}", address.emailId);
                }
        }

        public void EditContactDetails()
        {
            Console.WriteLine("**Enter The City Or State To Edit The Contact**");
            string firstName = Console.ReadLine();
            foreach (AddressBookMul address in AddressList)
            {
                if (address.firstName == firstName)
                {
                    //This Is The User Input For Which Field Want To Edit
                    Console.WriteLine("**1. First Name:**");
                    Console.WriteLine("**2.Last Name**");
                    Console.WriteLine("**3.Address**");
                    Console.WriteLine("**4.City**");
                    Console.WriteLine("**5.State**");
                    Console.WriteLine("**6.ZipCode**");
                    Console.WriteLine("**7.Phone Number**");
                    Console.WriteLine("**8.Email Address**");
                    Console.WriteLine("Enter The Field  For Edit**");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    //Using Switch Case Edit The Fields Choose By User.
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("*New First Name:*");
                            string newfirstName = Console.ReadLine();
                            address.firstName = newfirstName;
                            break;
                        case 2:
                            Console.WriteLine("*New Last Name:*");
                            string newlastName = Console.ReadLine();
                            address.lastName = newlastName;
                            break;
                        case 3:
                            Console.WriteLine("*New Address:*");
                            string newaddress = Console.ReadLine();
                            address.address = newaddress;
                            break;
                        case 4:
                            Console.WriteLine("*New City Name:*");
                            string newcity = Console.ReadLine();
                            address.city = newcity;
                            break;
                        case 5:
                            Console.WriteLine("*New State Name:*");
                            string newstate = Console.ReadLine();
                            address.state = newstate;
                            break;
                        case 6:
                            Console.WriteLine("* New ZipCode:*");
                            int newzipcode = Convert.ToInt32(Console.ReadLine());
                            address.zipCode = newzipcode;
                            break;
                        case 7:
                            Console.WriteLine("*New Phone Number:*");
                            long newphoneNumber = Convert.ToInt64(Console.ReadLine());
                            address.phoneNumber = newphoneNumber;
                            break;
                        case 8:
                            Console.WriteLine("*New EmailId:*");
                            string newemailId = Console.ReadLine();
                            address.emailId = newemailId;
                            break;

                        default:
                            Console.WriteLine("**Oops!Please Enter Correct Choice**");
                            break;
                    }
                }
            }
        }
        //Here Create Method For Deleting Contact Details....
        public void DeleteContactDetails()
        {
            //Taking Input From User (State Or City) To Delete Contact Details.
            Console.Write("**Enter The City Or State Details For Deleting: **");
            string DeleteContacts = Console.ReadLine();   //Stored This Input Taking From User.
            foreach (AddressBookMul Delete in AddressList)
            {
                if (Delete.firstName == DeleteContacts)
                {
                    AddressList.Remove(Delete);
                    Console.WriteLine("**Contact Details Removed**");
                    break;
                }
                else
                {
                    Console.WriteLine("**Oops!Invalid Input(City Or State) Not Present In Address Book **");
                }
            }
        }
    }

}
