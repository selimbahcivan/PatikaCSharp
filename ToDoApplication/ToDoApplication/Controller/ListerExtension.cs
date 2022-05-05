using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Models;

namespace ToDoApplication.Controller
{
    internal static class ListerExtension
    {
        internal static void ListeleExt(this List<Card> list, string listName)
        {
            Console.WriteLine($"{listName} Line");
            Console.WriteLine("*****************************");

            foreach(var item in list)
            {
                Console.WriteLine("Başlık       : " + item.Baslik);
                Console.WriteLine("İçerik       : " + item.Icerik);
                Console.WriteLine("Atanan Kişi  : " + item.AtananKisi);
                Console.WriteLine("Büyüklük     : " + item.Kod);
                Console.WriteLine("-");
            }

            if(list.Count == 0)
            {
                Console.WriteLine($"{listName} listesi boş !");
            }
        }
    }
}
