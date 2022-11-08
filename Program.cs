using System;


namespace AddressBookDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Welcome To Address Book Program---------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1.Checking No Duplicate Entry In Addressbook");
            Console.WriteLine("2.Check To Search Person By City Or State In Multiple AddressBook");
            Console.WriteLine("3.Check To View Person By City Or State In AddressBook");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.WriteLine("------Output For Checking No Duplicating Entry In Address Book------");
                    //Here ,Creating Instance And Call The Method To Add New Contact.
                    AddressBook contact = new AddressBook();
                    contact.CreateContact();
                    Console.WriteLine("---------------------");
                    contact.Display();
                    Console.WriteLine("---------------");
                    contact.AddPerson();
                    contact.EditContact();
                    //Here ,Edit Contact Details  And Call The Method For Editing Contact.
                    Console.WriteLine("Edit Contact Using First Name. 1:Y/N");
                    Console.Write("Enter Your Choice: ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "Y")
                    {
                        contact.EditContact();
                        contact.Display();

                    }
                    break;
                case 2:



                    Console.WriteLine("----------Output For Check To Search Person City Or State Using Multiple Address Book-----------");
                    // Here,Creating Instance For Call The Methods To Edit The And Delete Contact details.
                    MultipleContact mul = new MultipleContact();
                    Console.WriteLine("--------------------------------------");

                Add:
                    Console.WriteLine("Enter Details : Y/N");
                    Console.Write("Enter Your Choice:");
                    string choice2_1 = Console.ReadLine();
                    if (choice2_1 == "Y")
                    {
                        mul.AddMultipleNewContact();
                        mul.DisplayContactDetails();
                        goto Add;

                    }
                //Asking User to Edit Contact Details 
                Edit:
                    if (mul.AddressList.Count > 0)//Check no. of contact is greater than 0.
                    {
                        //Asking User to Edit Contact Details If Y Then Proceed...... 
                        Console.WriteLine("Edit contact using City or State ? Y/N");
                        Console.WriteLine("Enter Your Choice");
                        string choice2_2 = Console.ReadLine();
                        if (choice2_2 == "Y")
                        {
                            mul.EditContactDetails();
                            mul.DisplayContactDetails();
                            goto Edit;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Contact details is not present in address book");
                    }

                Delete:
                    //Asking User to Delete Contact Details 
                    if (mul.AddressList.Count > 0)//Check no. of contact is greater than 0.
                    {
                        //Asking User to Delete Contact Details If Y Then Proceed...... 
                        Console.WriteLine("Edit contact using City or State ? Y/N");
                        Console.WriteLine("Enter Your Choice");
                        string choice3_2 = Console.ReadLine();
                        if (choice3_2 == "Y")
                        {
                            mul.EditContactDetails();
                            mul.DisplayContactDetails();
                            goto Edit;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Contact details is not present in address book for delete.");
                    }
                    break;



                case 3:

                    Console.WriteLine("Output For View Person Using City Or State In Address Book");
                    //Here ,Creating Instance And Call The Method To Add New Contact.
                    ViewContact view = new ViewContact();
                    view.CreateContact();
                    Console.WriteLine("---------------------");
                    view.Display();
                    view.AddPerson();
                    Console.WriteLine("--------------------");
                    view.Display();
                    view.EditContact();
                    //Here ,Edit Contact Details  And Call The Method For Editing Contact.
                    Console.WriteLine("Edit Contact Using City Or State 1:Y/N");
                    Console.Write("Enter Your Choice: ");
                    string choice3 = Console.ReadLine();
                    if (choice3 == "Y")
                    {
                        view.EditContact();
                        view.Display();

                    }
                    break;



            }

        }
    }
}