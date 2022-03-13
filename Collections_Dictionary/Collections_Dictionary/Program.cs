using System;
using System.Collections.Generic;

namespace Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            // KEY ' ler UNIQUE olmalı !!!!!

            kullanıcılar.Add(24, "Yavuz Selim");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(29, "adasdasda");

            // Dizinin elemanlarına erişim
            Console.WriteLine("****** Elemanlara Erişim *******");
            Console.WriteLine(kullanıcılar[12]);
            foreach(var item in kullanıcılar)
            {
                Console.WriteLine(item);   
            }

            // Count 
            Console.WriteLine("-----Count-------");
            Console.WriteLine(kullanıcılar.Count);

            // ContainsKey  / ContainsValue
            Console.WriteLine("------- ContainsKey / ContainsValue -------");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Ömer Faruk"));

            // Remove
            Console.WriteLine("------- Remove -------");
            kullanıcılar.Remove(12);
            foreach(var i in kullanıcılar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();    
            foreach (var i in kullanıcılar)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine();
            foreach (var i in kullanıcılar)
            {
                Console.WriteLine(i.Key);
            }
            Console.WriteLine();

            // Keys

            foreach (var i in kullanıcılar.Keys)
            {
                Console.WriteLine(i );
            }

            // Values ' a erişim
            foreach (var i in kullanıcılar.Values )
            {
                Console.WriteLine(i);
            }
        }
    }
}
