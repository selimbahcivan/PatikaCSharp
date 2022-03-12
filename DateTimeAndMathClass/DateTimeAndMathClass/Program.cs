using System;

namespace DateTimeAndMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine();
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));
            Console.WriteLine();
            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // 12 
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Cmt
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Cumartesi

            Console.WriteLine(DateTime.Now.ToString("MM")); // 03 
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Mart

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022


            // MATH LIBRARY

            Console.WriteLine(Math.Abs(-69));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // 23 En yakın büyük olan sayıyı getirir.
            Console.WriteLine(Math.Round(22.3)); // en yakın sayıya yuvarlar. 22 
            Console.WriteLine(Math.Round(22.7)); // en yakın sayıya yuvarlar. 23 
            Console.WriteLine(Math.Floor(22.7)); // 22 En yakın küçük olan sayıyı getirir

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Pow(3,4)); // üs alır
            Console.WriteLine(Math.Sqrt(16)); // karekök
            Console.WriteLine(Math.Log(10)); // e tabanında logaritma
            Console.WriteLine(Math.Log10(1)); // logaritma 10 tabanında
            Console.WriteLine(Math.Exp(3)); // exponansiyel ( e üzeri 3 )

            
            


            

        }
    }
}
