


using System.Collections.Generic;
using ToDoApplication.Models;

namespace ToDoApplication
{

    public static class SampleData
    {
        public static void Add(this List<Card> list)
        {
            list.Add(new Card() { Baslik = "Alışveriş", Icerik= "Peynir", AtananKisi = Member.Members[1] , Kod= Buyukluk.XS });
            list.Add(new Card() { Baslik = "Elektronik", Icerik = "Bilgisayar", AtananKisi = Member.Members[2], Kod = Buyukluk.M });
            list.Add(new Card() { Baslik = "Spor", Icerik = "Koşu", AtananKisi = Member.Members[3], Kod = Buyukluk.XL });
           
        }
    }
}
