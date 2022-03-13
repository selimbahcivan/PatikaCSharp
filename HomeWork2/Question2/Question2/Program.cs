using System;
using System.Collections;
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Max3Numbers = new ArrayList();
            ArrayList Min3Numbers = new ArrayList();
            ArrayList arrayList = new ArrayList();
            
           
                for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine("{0}. sayıyı giriniz : ",i);
                    int n = int.Parse(Console.ReadLine());
                    arrayList.Add(n);
                }
 
            arrayList.Sort();

            for (int i = 0; i < 3; i++)
            {
                Min3Numbers.Add(arrayList[i]);
            }

            for ( int i = arrayList.Count - 1; i >= arrayList.Count-3; i--)
            {
                Max3Numbers.Add(arrayList[i]);
            }
            
            int maxAvg = 0;
            int minAvg = 0;

            Console.WriteLine("----------Max 3 Numbers---------");
            foreach(var i in Max3Numbers)
            {
                Console.WriteLine(i);
                maxAvg += Convert.ToInt32(i);
               
            }
            Console.WriteLine("----------Min 3 Numbers -------------");
            foreach (var i in Min3Numbers)
            {
                Console.WriteLine(i);
                minAvg += Convert.ToInt32(i);

            }
            Console.WriteLine("Max Numbers' Average : " + (maxAvg / Max3Numbers.Count));
            Console.WriteLine("Max Numbers' Average : " + (minAvg / Min3Numbers.Count));


        }
    }
}
