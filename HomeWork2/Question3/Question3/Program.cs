using System;
using System.Collections.Generic;
namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> myList = new List<string>();

            string[] vowels = { "a","e","i","o","u" };

            Console.WriteLine("Bir cümle giriniz :");

            myList.Add(Console.ReadLine());

           
            
            for (int i = 0; i < myList.Count; i++)
                for(int j = 0; j < vowels.Length; j++)
                {
                    if (myList[i].Contains(vowels[j]))
                    {
                       list.Add(vowels[j]);
                    }
                }
            
            list.ForEach(item => Console.WriteLine(item));

            
        }
    }
}
