using System;

namespace secondWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz : ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz : ", i+1);
                int number = int.Parse(Console.ReadLine());
                if (number == m || number % m == 0 )
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
