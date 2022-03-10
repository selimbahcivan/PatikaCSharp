using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Yavuz Selim";
            string degisken = "Yavuz Selim Bahcıvan";

            // Length
            Console.WriteLine(degisken.Length);

            // ToUpper , ToLower
            Console.WriteLine(name.ToUpper() + " " + name.ToLower()); 

            // Concat
            Console.WriteLine(String.Concat(name ," Bahcıvan"," Merhaba !")); // name degiskenine girelen string değerleri ekler.

            // Compare , CompareTo , 1. 2.ye göre; eşitse 0 büyükse 1 küçükse -1 değerini alır.
            Console.WriteLine(name.CompareTo(degisken)); 
            Console.WriteLine(String.Compare(name,degisken,true)); //true yaparsak büyük küçük harf duyarsız olur !

            // Contains
            Console.WriteLine(degisken.Contains(name)); // degisken, name ' i kapsar.
            Console.WriteLine(degisken.EndsWith("Bahcıvan")); 
            Console.WriteLine(degisken.StartsWith("Selim"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("Selin")); // bulamazsa -1 döner.

            // Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba ! ")); // 0 . indeksten başlar ve value'yu ekler.
            Console.WriteLine(degisken.LastIndexOf("a")); // Sondaki a ' yı getirdi.

            // PadLeft ve PadRight
            Console.WriteLine(name + degisken.PadLeft(30));
            Console.WriteLine(name + degisken.PadLeft(30,'*'));
            Console.WriteLine(name.PadRight(50) + degisken);
            Console.WriteLine(name.PadRight(50,'~') + degisken);

            // Remove
            Console.WriteLine(degisken.Remove(11)); // 11. indeksten başla sonuna kadar sil
            Console.WriteLine(degisken.Remove(12,3)); //11.indeksten başla 3 karakter sil
            Console.WriteLine(degisken.Remove(0,1)); // 0. indeksten başla 1 karakter sil 

            // Replace
            Console.WriteLine(degisken.Replace("Selim","53LiM"));
            Console.WriteLine(degisken.Replace(" ","~"));

            // Split
            Console.WriteLine(degisken.Split(' ')[1]); // boşluklara göre ayır ve diziye ata ve 1.indeksteki diziyi getir

            // Substring
            Console.WriteLine(degisken.Substring(4)); // 4.indeksten başla sonuna kadar getir .
            Console.WriteLine(degisken.Substring(4,6)); // 4.indeksten başla 6 karakter getir .
            


        }
    }
}
