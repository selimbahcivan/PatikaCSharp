using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApplication.Models;

namespace ToDoApplication
{
    internal static class TasınacakKart
    {
        public static void Kart(this List<Card> list, string cardTitle)
        {
            Console.WriteLine("Bulunan Kart Bilgileri:");
            Console.WriteLine("********************************");
            Console.WriteLine("Başlık       : " + list.Where(c => c.Baslik == cardTitle).FirstOrDefault().Baslik);
            Console.WriteLine("İçerik       : " + list.Where(c => c.Baslik == cardTitle).FirstOrDefault().Icerik);
            Console.WriteLine("Atanan Kişi  : " + list.Where(c => c.Baslik == cardTitle).FirstOrDefault().AtananKisi);
            Console.WriteLine("Büyüklük     : " + list.Where(c => c.Baslik == cardTitle).FirstOrDefault().Kod);
            Console.WriteLine();

        }
    }
}
