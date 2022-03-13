using System;

namespace Struct
{
    // 16 BYTE' a kadar veriler için STRUCT, 16'dan büyükler için CLASS kullanmakta fayda var.
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLASS
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.AlanHesapla());

            // STRUCT

            // Dikdortgen_Struct dikdortgen_struct; -------> şeklinde nesne oluşturmadan yazılırsa başlangıç değerlerini -
            // Class'taki default constructor gibi atamaz.Kendimiz yazmamız gerekir.(aşağıdaki gibi)

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct(3,4);

            //dikdortgen_Struct.KisaKenar = 3;
            //dikdortgen_Struct.UzunKenar = 4;

            Console.WriteLine("Struct Alan Hesabı : {0}", dikdortgen_Struct.AlanHesapla());
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        // public Dikdortgen_Struct() { } ** DEFAULT CONSTRUCTOR (parametresi olmayan ) KULLANILAMIYOR STRUCT'TA
        public Dikdortgen_Struct(int kisaKenar,int uzunKenar) // BU ŞEKİLDE KABUL EDİYOR
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
