using Data_AS.EntityModels.Korisnici;
using Data_AS.EntityModels.Vozila;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels
{
    public class Nabavka
    {
        public int Id { get; set; }

        public int VoziloId { get; set; }
        public Vozilo Vozilo { get; set; }

        public int ZaposlenikId { get; set; }
        public Zaposlenik Zaposlenik { get; set; }

        public DateTime DatumNabavke { get; set; }

        public float Cijena { get; set; }
    }
}
