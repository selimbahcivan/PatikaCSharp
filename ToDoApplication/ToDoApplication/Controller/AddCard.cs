using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Models;

namespace ToDoApplication
{
    internal partial class Program
    {
        public class AddCard
        {
            public static void KartEkle(List<Card> addCard)
            {
                string baslik, icerik;
                int kisiId;
                Buyukluk secilenBuyukluk = 0;

                Console.WriteLine("Başlık Giriniz                                                     : ");
                baslik = Console.ReadLine();

                Console.WriteLine("İçerik Giriniz                                                     : ");
                icerik = Console.ReadLine();

                Console.WriteLine("Atanan Kişi -> Charles(1), Carlos(2), Max(3), Lewis(4), Daniel(5)  : ");
                kisiId = int.Parse(Console.ReadLine());

                Console.WriteLine("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5)                 : ");

                secilenBuyukluk = (Buyukluk)StringToByte(Console.ReadLine());

                byte StringToByte(string inputString)
                {
                    if (Byte.TryParse(inputString, out byte outputByte))
                    {
                        return outputByte;
                    }
                    return 1;
                }

                addCard.Add(new Card() { Baslik = baslik, Icerik = icerik, AtananKisi = Member.Members[kisiId], Kod = secilenBuyukluk });

                Console.WriteLine();

                if (addCard.Where(item => item.Baslik == baslik && item.Icerik == icerik).Count() == 1)
                {
                    Console.WriteLine("Kart başarıyla eklendi !");
                }
                else
                {
                    Console.WriteLine("Aynı başlıktan birden fazla olamaz !");
                    Console.WriteLine("Tekrar denemek için (1)\n" + "Çıkış yapmak için (2) ' yi tuşlayın.");

                    if (Console.ReadLine() == "1")
                    {
                        KartEkle(addCard);
                    }
                    else if (Console.ReadLine() == "2")
                    {
                        Console.WriteLine("Çıkış yapılıyor...");
                    }
                }
            }
        }
    }
}
