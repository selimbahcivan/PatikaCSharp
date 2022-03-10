using System;

namespace firstWork
{
    /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
    Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= n; i++ )
            {
                Console.WriteLine("{0} . sayıyı giriniz : ", i);
                int number = int.Parse(Console.ReadLine());
                
                if(number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
