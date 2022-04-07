using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.Shared
{
    public class RefVrijednostiVozilo
    {
        public List<SelectListItem> Marke { get; set; }
        public List<SelectListItem> Modeli { get; set; }
        public List<SelectListItem> Pogon { get; set; }
        public List<SelectListItem> BrojVrata { get; set; }
        public List<SelectListItem> Transmisija { get; set; }
        public List<SelectListItem> Boje { get; set; }
        public List<SelectListItem> VrsteKaroserije { get; set; }
        public List<SelectListItem> VrsteMotora { get; set; }
        public List<SelectListItem> VrsteSvjetla { get; set; }
        public List<SelectListItem> EmisioniStandardi { get; set; }
        public List<SelectListItem> Gorivo { get; set; }
        public List<SelectListItem> VrsteKlime { get; set; }
        public List<SelectListItem> PrkingSenzori { get; set; }
        public List<SelectListItem> GodineProizvodnje { get; set; }
        public List<SelectListItem> BrojStepeniPrijenosa { get; set; }
    }
}
