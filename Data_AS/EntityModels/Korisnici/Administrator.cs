using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels.Korisnici
{
    public class Administrator 
    {
        public int ID{ get; set; }
        public Korisnik Korisnik{ get; set; }
        public string KorisnikId { get; set; }
    }
}
