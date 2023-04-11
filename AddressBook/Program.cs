using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Address Book...");
            AddressBooks Book = new AddressBooks();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Edit Contact \n5.Delete Contact \n6.MulpliContact \n7.Create Address Books \n8.Display AddressBooks \n9.Check for Duplicate Entry \n10.Search Person by City or State \n11.view Person by City or State  \n12.Count Contacts by City or State \n13.SortPersonUsingName \n14..ReadAndWriteAddressBookContactsToFile \n15:ReadandwriteAddresbookUsingCsvfile \n16:ReadandWriteAddressbookusingJsonfile \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Book.CreateContact();
                        break;
                    case 2:
                        Book.AddContact();
                        break;
                    case 3:
                        Book.DisplayContact();
                        break;
                    case 4:
                        Book.EditContact();
                        break;
                    case 5:
                        Book.DeleteContact();
                        break;
                    case 6:
                        Book.AddMultipleContact();
                        break;
                    case 7:
                        Book.CreateAddressBooks();
                        break;
                    case 8:
                        Book.DisplayAddressBooks();
                        break;
                    case 9:
                        Book.CheckDuplicateEntry();
                        break;
                    case 10:
                        Book.SearchPersonByCityOrState();
                        break;
                    case 11:
                        Book.SearchPersonByCityOrState();
                        break;
                    case 12:
                        Book.CountContactsByCityOrState();
                        break;
                    case 13:
                        Book.SortPersonUsingName();
                        break;
                    case 14:
                        Book.ReadAndWriteAddressBookContactsToFile();
                        break;
                    case 15:
                        Book.ReadAndWriteCSVFile();
                        break;
                    case 16:
                        Book.ReadWritePersonContactsToJSONFile();
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();   
        }
    }
}
