using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Models;

namespace ToDoApplication
{
    public class DeleteCard
    {
        public static void KartSil(List<Card> deleteCard)
        {
            Console.WriteLine("Silmek istediğiniz kart başlığını yazınız:  ");
            string cardTitle = Console.ReadLine();

            Console.WriteLine();

            if (deleteCard.Where(ct => ct.Baslik == cardTitle).Count() == 1)
            {
                deleteCard.Remove(deleteCard.Where((ct) => ct.Baslik == cardTitle).First());
            }
            else
            {
                Console.WriteLine("Kart bulunamadı.");
                Console.WriteLine("Yeni Girişyapmak istiyor musunuz? (y/n)");
                if (Convert.ToString(Console.ReadLine()) == "y")
                {
                    KartSil(deleteCard);
                }
                else
                {
                    Console.WriteLine("Kart silme işlemi iptal edildi!");
                }
            }
        }
    }
}
