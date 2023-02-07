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
            Book.CreateContact();
            Console.ReadLine();   
        }
    }
}
