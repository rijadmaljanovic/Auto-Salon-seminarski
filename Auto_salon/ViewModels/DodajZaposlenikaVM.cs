using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class DodajZaposlenikaVM
    {
        public int ZaposlenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime{ get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public string Email{ get; set; }
        public string JMBG{ get; set; }

        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumZaposlenja { get; set; }

    }
}
