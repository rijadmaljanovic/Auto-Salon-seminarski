using Data_AS.EntityModels.Korisnici;
using Data_AS.EntityModels.Vozila;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels
{
    public class VoziloFavorit
    {
        public int Id { get; set; }

        public int KupacId { get; set; }
        public Klijent Klijent { get; set; }

        public int VoziloId { get; set; }
        public Vozilo Vozilo { get; set; }
    }
}
