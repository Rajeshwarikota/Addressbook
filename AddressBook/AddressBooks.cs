using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBooks
    {
        List<Contact> addressBookList = new List<Contact>();
        public void CreateContact()
        {
            Contact contacts = new Contact();

            Console.WriteLine("Enter First Name : ");
            contacts.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contacts.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            contacts.email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            contacts.phoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            contacts.address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            contacts.zipCode = Console.ReadLine();
            Console.WriteLine("Contact created");
        }
        public void AddContact()
        {
            Contact addContact = new Contact();
            Console.WriteLine("Enter First Name : ");
            addContact.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            addContact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            addContact.email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            addContact.phoneNo = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            addContact.address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            addContact.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            addContact.city = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            addContact.zipCode = Console.ReadLine();
            addressBookList.Add(addContact);
            Console.WriteLine("Contact Added Successfully!");
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the First Name to Check : ");
            string firstName = Console.ReadLine();
            foreach (Contact data in addressBookList)
            {
                if (data.firstName == firstName)
                {
                    Console.WriteLine("Edit Contact details");
                    Console.WriteLine("\n1.First Name \n2.Last Name \n3.Address 4.city \n5.state \n6.zip Code \n7.Phone Number \n8.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name : ");
                            data.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name");
                            data.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip Code");
                            data.zipCode = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone Number");
                            data.phoneNo = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter Email");
                            data.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Select Correct number");
                            break;
                    }
                    Console.WriteLine("Contact Edited Successfully");
                }
                else
                {
                    Console.WriteLine("No Contact Exists with this First Name : " + firstName);
                }
            }
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter the number of Contacts to Add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    AddContact();
                }
            }
            else 
            {
                Console.WriteLine("Enter the correct Number");
            }
        }
        public void DeleteContact()
            {         
               Console.WriteLine("Enter the First Name to Check : ");
               string firstName = Console.ReadLine();
               foreach (Contact data in addressBookList)
               {
                  if (data.firstName == firstName)
                 {
                    addressBookList.Remove(data);
                    Console.WriteLine("Contact delete Scccessfully");
                    return;
                  }
               else
               {
                Console.WriteLine("No Contact Exists with this First Name : " + firstName);
               }
            }
        }
        public void DisplayContact()
        {
            foreach (Contact display in addressBookList)
            {
               Console.WriteLine("Contact Details");
               Console.WriteLine(display.firstName);
               Console.WriteLine(display.lastName);
               Console.WriteLine(display.email);
               Console.WriteLine(display.phoneNo);
               Console.WriteLine(display.address);
               Console.WriteLine(display.state);
               Console.WriteLine(display.city);
               Console.WriteLine(display.zipCode);
            }
        }
    }
}

