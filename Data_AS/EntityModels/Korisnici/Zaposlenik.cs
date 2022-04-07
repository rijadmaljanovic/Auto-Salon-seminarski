using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels.Korisnici
{
    public class Zaposlenik
    {
        public int Id { get; set; }

        public string Adresa { get; set; }
        public string JMBG { get; set; }

        public DateTime DatumZaposlenja { get; set; }
        public Korisnik Korisnik { get; set; }
        public string KorisnikId { get; set; }
    }
}
