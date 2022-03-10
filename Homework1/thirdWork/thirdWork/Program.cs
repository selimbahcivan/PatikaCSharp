using System;

namespace thirdWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz : ");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];
            for ( int i = 0; i < n; i++ )
            {
                Console.WriteLine("{0}. kelimeyi giriniz : ", i + 1);
                array[i] = Console.ReadLine();
            }
            for ( int i = n - 1; i >= 0; i-- )
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
