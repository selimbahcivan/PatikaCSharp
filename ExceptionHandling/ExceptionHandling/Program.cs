using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Bir Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata : " +e.Message.ToString());
                
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı...");
            }
            */
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }
            /*catch (ArgumentNullException e)
            {
                Console.WriteLine("Boş değer girdiniz ! ");
                Console.WriteLine(e);
            }*/
            /*catch (FormatException e)
            {
                Console.WriteLine("Veri tipi uygun değil ! ");
                Console.WriteLine(e);

            }*/
            catch (OverflowException e)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz ! ");
                Console.WriteLine(e);   
            }
            {

            }  
            
        }
    }
}
