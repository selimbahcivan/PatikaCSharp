using System;

namespace Enum
{
    internal class Program
    {
        // ÇOK KULLANDIĞIMIZ SABİTLERİ ENUM'LA BELİRTİRSEK OKUNABİLİRLİK VE KULLANIM KOLAYLIĞI SAĞLAYACAK BİZE.
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar); // string şeklinde Pazar yazdırdı.
            Console.WriteLine((int)Gunler.Cumartesi);


            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarısı çok soğuk");
            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }
            
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }
    
    enum HavaDurumu
    {
        Soguk = 5,

        Normal = 20,

        Sıcak = 25,

        CokSıcak = 30
    }
}
