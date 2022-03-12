using System;
using System.Collections.Generic;

namespace GenericCollections_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(7);
            sayiListesi.Add(8);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //foreach (int i in sayiListesi)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (string i in renkListesi)
            //{
            //    Console.WriteLine(i);
            //}
            sayiListesi.ForEach(i => Console.WriteLine(i));
            renkListesi.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            // Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(i => Console.WriteLine(i));
            renkListesi.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(2);

            sayiListesi.ForEach(i => Console.WriteLine(i));
            renkListesi.ForEach(i => Console.WriteLine(i));

            // Liste içerisinde arama 

            if(sayiListesi.Contains(7))
            {
                Console.WriteLine("7 Liste içerisinde bulundu ! ");
            }

            // Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı")); // kırmızının indexini verdi.

            // Dizi'yi List' e çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.ForEach(i => Console.WriteLine(i));

            // Liste Temizleme 

            hayvanListesi.Clear();


            // List içerisinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Selim";
            kullanıcı1.Soyisim = "Bahcıvan";
            kullanıcı1.Yas = 24;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Ömer";
            kullanıcı2.Soyisim = "Faruk";
            kullanıcı2.Yas = 27;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar() {
                Isim = "Muhammet",
                Soyisim = "Hüseyin",
                Yas = 31
            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı : " + kullanıcı.Yas);
            }
            yeniListe.Clear();
            foreach (Kullanıcılar kullanıcı in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı : " + kullanıcı.Yas);
            }

            

        }
    }
    public class Kullanıcılar
    {
        private string isim;

        private string soyisim;

        private int yas;

        public string Isim { get { return isim; } set { isim = value; } }

        public string Soyisim { get { return soyisim; } set { soyisim = value; } }

        public int Yas { get { return yas; } set { yas = value; } }
    }


}
