using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels.Korisnici
{
    public class Klijent
    {
        public int ID { get; set; }
        public Korisnik Korisnik { get; set; }
        public string KorisnikId { get; set; }
        public string Adresa { get; set; }

        public string Telefon { get; set; }
        public string Grad { get; set; }
    }
}
