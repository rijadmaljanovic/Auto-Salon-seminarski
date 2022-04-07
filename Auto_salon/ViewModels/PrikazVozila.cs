using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class PrikazVozila
    {
        public int Id{ get; set; }
        public string Model{ get; set; }
        public string Marka { get; set; }
        public int GodinaProizvodnje{ get; set; }
        public float? Cijena{ get; set; }
        public string Transmisija{ get; set; }
    }
}
