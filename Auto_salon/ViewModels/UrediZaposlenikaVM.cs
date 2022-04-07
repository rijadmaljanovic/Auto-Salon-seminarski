using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class UrediZaposlenikaVM
    {
        public string ZaposlenikId { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }
        public string JMBG { get; set; }

        public string DatumZaposlenja { get; set; }

        public string Adresa { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }


    }
}

