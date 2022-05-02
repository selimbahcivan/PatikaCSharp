using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Models
{
    internal class Transactions
    {
        internal void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Çıkış Yapmak");
            Console.WriteLine();
        }

        internal void AddNewPerson(List<Contacts> contacts)
        {
            Console.WriteLine("*************** ADD *************** ");
            Console.WriteLine();

            Console.WriteLine("Lütfen isim giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz");
            int phone = int.Parse(Console.ReadLine());

            Contacts newContact = new Contacts(name, surname, phone);
            contacts.Add(newContact);
            Console.WriteLine();
            Console.WriteLine("Kişi rehbere eklendi");

            foreach (var item in contacts)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.PhoneNumber);
            }
        }
        internal void DeletePerson(List<Contacts> contacts)
        {
            Console.WriteLine("*************** DELETE *************** ");
            Console.WriteLine();

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string nameOrSurname = Console.ReadLine();

            var findContact = contacts.Find(a => a.Name.Equals(nameOrSurname) || a.Surname.Equals(nameOrSurname));

            if (findContact != null)
            {
                Console.WriteLine($"{nameOrSurname} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y/n)");
                string confirmation = Console.ReadLine();
                if (confirmation == "y")
                {
                    contacts.Remove(findContact);
                    Console.WriteLine("Silme işlemi başarıyla gerçekleştirildi!");
                }
                else if (confirmation == "n")
                {
                    Console.WriteLine("Silme işlemi iptal edildi...");
                }
                else
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız !");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                  "* Silmeyi sonlandırmak için : (1)\n" +
                                  "* Yeniden denemek için      : (2)");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    case "2":
                        DeletePerson(contacts);
                        Console.WriteLine("Kişi rehberden silindi");
                        break;
                    default:
                        Console.WriteLine("Yanlış bir tuşa bastınız !");
                        break;
                }
            }
        }
        internal void UpdateContact(List<Contacts> contacts)
        {
            Console.WriteLine("********************** UPDATE **********************");
            Console.WriteLine();

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameOrSurname = Console.ReadLine();

            var findContact = contacts.Find(a => a.Name.Equals(nameOrSurname) || a.Surname.Equals(nameOrSurname));
            if (findContact != null)
            {
                Console.WriteLine("Bulunan kişi : ");
                Console.WriteLine();
                Console.WriteLine(findContact.Name + " " + findContact.Surname + " " + findContact.PhoneNumber);
                Console.WriteLine();

                Console.WriteLine("Yeni numarayı giriniz : ");
                int newNumber = int.Parse(Console.ReadLine());
                findContact.PhoneNumber = newNumber;
                Console.WriteLine("Güncelleme işlemi başarıyla tamamlandı !");
                Console.WriteLine(findContact.Name + " " + findContact.Surname + " " + findContact.PhoneNumber);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                                 "* Güncellemeyi sonlandırmak için: (1)\n" +
                                 "* Yeniden denemek için: (2)"
                                 );
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                }
                else if (choice == "2")
                {
                    UpdateContact(contacts);
                }
                else
                {
                    Console.WriteLine("Yanlış bir tuşa bastınız !");
                }
            }
        }
        internal void Display(List<Contacts> contacts)
        {
            Console.WriteLine("**************** DISPLAY PHONE LIST *****************");
            Console.WriteLine();

            foreach (Contacts item in contacts)
            {
                Console.WriteLine("İsim : " + item.Name);
                Console.WriteLine("Soyisim : " + item.Surname);
                Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                Console.WriteLine("-");
            }
        }
        internal void FindContact(List<Contacts> contacts)
        {
            Console.WriteLine("***************** FIND CONTACT ****************");
            Console.WriteLine();

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n" +
                              "İsim veya soyisime göre arama yapmak için: (1)\n" +
                              "Telefon numarasına göre arama yapmak için: (2)");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                string nameOrSurname = Console.ReadLine();

                foreach (Contacts item in contacts)
                {
                    if (item.Name == nameOrSurname || item.Surname == nameOrSurname)
                    {
                        Console.WriteLine("İsim             : " + item.Name);
                        Console.WriteLine("Soyisim          : " + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.PhoneNumber);
                        Console.WriteLine("-");
                    }
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Telefon numarasını giriniz : ");
                int phoneNumber = int.Parse(Console.ReadLine());

                var findContact = contacts.Find(x => x.PhoneNumber == phoneNumber);
                if (findContact != null)
                {
                    Console.WriteLine("Bulunan Kişi : ");
                    Console.WriteLine("İsim             : " + findContact.Name);
                    Console.WriteLine("Soyisim          : " + findContact.Surname);
                    Console.WriteLine("Telefon Numarası : " + findContact.PhoneNumber);
                }
                else
                {
                    Console.WriteLine("Listede böyle bir numara yok !");
                }
            }
            else
            {
                Console.WriteLine("Yanlış bir tuşa bastınız !");
            }
        }

    }
}
