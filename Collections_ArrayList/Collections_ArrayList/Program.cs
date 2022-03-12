using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collections namespace

            ArrayList ArrayList = new ArrayList();
            //ArrayList.Add("Yavuz");
            //ArrayList.Add(24);
            //ArrayList.Add(true);
            //ArrayList.Add('S');

            // İçerisindeki verilere erişim

            //Console.WriteLine(ArrayList[1]);

            foreach (var i in ArrayList)
            {
                Console.WriteLine(i);
            }

            // AddRange Birden fazla elemanı eklemek.

            Console.WriteLine("-------- Add Range ------");
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };

            //ArrayList.AddRange(renkler);
            ArrayList.AddRange(sayilar);

            foreach (var i in ArrayList)
            {
                Console.WriteLine(i);
            }

            // Sort
            Console.WriteLine("******** Sort *********");
            ArrayList.Sort(); // sıralama için compare etmek istiyor fakat edemediği için runtime'da patlıyor.

            foreach (var i in ArrayList)
            {
                Console.WriteLine(i);
            }

            // Binary Search

            Console.WriteLine("*************** Binary Search ******************");
            Console.WriteLine(ArrayList.BinarySearch(9)); // 9 ' un indexini verdi.

            // Reverse

            Console.WriteLine("**********Reverse**********");
            ArrayList.Reverse();   
            foreach (var i in ArrayList)
            {
                Console.WriteLine(i);
            }

            // Clear
            Console.WriteLine("-----------Clear-----------");

            ArrayList.Clear();  

            foreach (var i in ArrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
