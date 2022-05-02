namespace PhoneDirectory.Models
{
    internal class Contacts
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }

        public Contacts(string Ad, string Soyad, int Telefon)
        {
            this.Name = Ad;
            this.Surname = Soyad;
            this.PhoneNumber = Telefon;
        }
    }
}
