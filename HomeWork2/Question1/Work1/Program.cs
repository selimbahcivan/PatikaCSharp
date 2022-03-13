using System;
using System.Collections;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNum = new ArrayList();
            ArrayList notPrime = new ArrayList();
            
            int index = 1;
            int step = 20;
           
            while ( step > 0 ) { 
                Console.WriteLine("{0}. sayıyı giriniz ",index++);

                
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    
                    if ( number > 1 ) 
                    { 
                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                notPrime.Add(number);
                                break;
                            }
                        }

                        if (!notPrime.Contains(number))
                        {
                            primeNum.Add(number);
                        }
                        step--;
                    }
                    else
                    {
                           
                        Console.WriteLine("Negatif sayı girmeyiniz ! ");
                        index--;
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata : " + e.Message.ToString());
                    index--;
                    
                }            
            } 

            Console.WriteLine();

            primeNum.Sort();
            notPrime.Sort();
            int sumPrime = 0;
            int sumNotPrime = 0;
            Console.WriteLine("******* Prime*******");
            foreach (int i in primeNum)
            {
                Console.WriteLine(i);
                sumPrime += i;
            }

            
            Console.WriteLine("Prime Length : " +primeNum.Count);
            
            Console.WriteLine("Average Prime  : " + (sumPrime / primeNum.Count));

            Console.WriteLine("*******Not Prime*******");

            foreach (int i in notPrime)
            {
                Console.WriteLine(i);
                sumNotPrime += i;
            }
            
            Console.WriteLine("Not Prime Length : " +notPrime.Count);
            Console.WriteLine("Average Prime : " +(sumNotPrime / notPrime.Count));
        }
    }
}
