using System;

namespace fourthWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz : ");
            string str = Console.ReadLine();
            int countKelime = 1;
            int countHarf = 0;
            for ( int i = 0; i < str.Length; i++ )
            {
                if ( str[i] == ' ')
                {
                    countKelime++;
                }
                if ( str[i] != ' ')
                {
                    countHarf ++;
                }
            }
            Console.WriteLine("Toplam kelime : " + countKelime + "\nToplam harf : " + countHarf);
        }
    }
}
