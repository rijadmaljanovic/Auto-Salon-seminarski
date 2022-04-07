using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels.Korisnici
{
    public class Korisnik :IdentityUser
    {

        public string Ime { get; set; }
        
        public string Prezime { get; set; }
        public Zaposlenik Zaposlenik { get; set; }
        public Administrator Administrator{ get; set; }
        public Klijent Klijent { get; set; }

    }
}
