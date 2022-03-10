using System;

namespace RecursiveAndExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive Methods 
            int result = 1;
            for ( int i = 1; i < 5; i++ )
            {
                result = result * 3;    
            }
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(5, 3));

            // Extension Methods
            string ifade = "Selim Bahcıvan";
            bool sonuc = ifade.CheckSpaces(); 
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveSpaces());
            }
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.ToLower());

            int[] dizi = { 9, 31, 23, 55, 3, 5 };
            dizi.sortArray();
            dizi.display();

            int sayi = 5; 
            Console.WriteLine(sayi.isEvenNumber());

            string name = "Selim Bahcıvan";
            Console.WriteLine(name.getSecondCharacter());    
            

            






        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us )
        {
            if (us < 2 )
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param) 
        {
            return param.Contains(" ");
        }
        public static string RemoveSpaces(this string param)
        {
            string[] array = param.Split(" ");
            return string.Join("", array);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] sortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void display(this int[] param) 
        {
            foreach (int i in param)
            {
                Console.Write(i + " ");
            }
        }
        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string getSecondCharacter(this string param)
        {
            return param.Substring(1, 1);
        }
    }
}
