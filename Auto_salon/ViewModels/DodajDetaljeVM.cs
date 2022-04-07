using Data_AS.EntityModels.Vozila;
using Data_AS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class DodajDetaljeVM
    {
        public Vozilo Vozilo { get; set; }
        public float? NabavnaCijena { get; set; }
        public RefVrijednostiVozilo RefVrijednosti { get; set; }
        public string SifraVozila { get; set; }
    }
}
