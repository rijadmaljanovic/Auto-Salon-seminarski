using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class DodajVoziloVM
    {
        public int Id { get; set; }
        public float? Cijena { get; set; }
        public DateTime? RegistrovanDo { get; set; }
        public float? PredjeniKilometri { get; set; }
        public float? SnagaMotoraKW { get; set; }
        public int? SnagaMotoraKS { get; set; }
        public float? Kubikaza { get; set; }
        public string Marka { get; set; }
        //foreign key area

        public int ModelId { get; set; }
        public List<SelectListItem> Modeli { get; set; }

        public int BrojStepeniPrijenosaId { get; set; }
        public List<SelectListItem> BrojStepeniPrijenosa { get; set; }

        public int GorivoId { get; set; }
        public List<SelectListItem> Gorivo { get; set; }

        public int TransmisijaId { get; set; }
        public List<SelectListItem> Transmisija { get; set; }

        public int GodinaProizvodnjeId { get; set; }
        public List<SelectListItem> GodinaProizvodnje { get; set; }

        public int ParkingSenzorId { get; set; }
        public List<SelectListItem> ParkingSenzor { get; set; }

        public int VrstaMotoraId { get; set; }
        public List<SelectListItem> VrstaMotora { get; set; }


        public int VrstaKlimeId { get; set; }
        public List<SelectListItem> VrstaKlime { get; set; }


        public int TipVozilaId { get; set; }
        public List<SelectListItem> TipVozila { get; set; }


        public int BojaId { get; set; }
        public List<SelectListItem> Boja { get; set; }

        public int BrojVrataId { get; set; }
        public List<SelectListItem> BrojVrata { get; set; }


        public int PogonId { get; set; }
        public List<SelectListItem> Pogon { get; set; }


        public int EmisioniStandardId { get; set; }
        public List<SelectListItem> EmisioniStandard { get; set; }


        public int VrstaSvjetlaId { get; set; }
        public List<SelectListItem> VrstaSvjetla { get; set; }


        public int VrstaKaroserijeId { get; set; }
        public List<SelectListItem> VrstaKaroserije { get; set; }

        //bool area

        public bool ABS { get; set; }
        public bool Alarm { get; set; }
        public bool ESP { get; set; }
        public bool Bluetooth { get; set; }
        public bool Maglenke { get; set; }
        public bool Metalik { get; set; }
        public bool Mat { get; set; }
        public bool Tempomat { get; set; }

        [BindProperty]
        public List<IFormFile> Images { get; set; }
    }
}
