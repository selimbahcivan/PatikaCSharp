using PhoneDirectory.Models;
using System;
using System.Collections.Generic;

namespace PhoneDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            List<Contacts> contacts = new List<Contacts>();
            Transactions transactions = new Transactions();
            try
            {
                do
                {
                    transactions.Menu();
                    Console.Write("Seçiminiz : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            transactions.AddNewPerson(contacts);
                            break;
                        case 2:
                            transactions.DeletePerson(contacts);
                            break;
                        case 3:
                            transactions.UpdateContact(contacts);
                            break;
                        case 4:
                            transactions.Display(contacts);
                            break;
                        case 5:
                            transactions.FindContact(contacts);
                            break;
                    }
                } while (choice != 6);
            }
            catch 
            {
                Console.WriteLine("Lütfen belirtilen bir tuşa basın !!");
                transactions.Menu();
            }
            
            
            

            Console.ReadKey();
        }
    }
}
