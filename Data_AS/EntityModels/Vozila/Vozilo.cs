using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data_AS.EntityModels.Vozila
{
    public class Vozilo
    {
        public int Id { get; set; }

        public float? Cijena { get; set; }

        public DateTime? RegistrovanDo { get; set; }

        public float? PredjeniKilometri { get; set; }

        public float? SnagaMotoraKW { get; set; }

        public int? SnagaMotoraKS { get; set; }

        public float? Kubikaza { get; set; }

        public string Marka{ get; set; }
        //foreign key area

        public int? ModelId { get; set; }
        public ModelVozila Model { get; set; }

        public int BrojStepeniPrijenosaId { get; set; }
        public BrojStepeniPrijenosa BrojStepeniPrijenosa { get; set; }

        public int GorivoId { get; set; }
        public Gorivo Gorivo { get; set; }

        public int TransmisijaId{ get; set; }
        public Transmisija Transmisija { get; set; }

        public int GodinaProizvodnjeId { get; set; }
        public GodinaProizvodnje GodinaProizvodnje { get; set; }

        public int ParkingSenzorId { get; set; }
        public ParkingSenzor ParkingSenzor { get; set; }

        public int VrstaMotoraId { get; set; }
        public VrstaMotora VrstaMotora { get; set; }


        public int VrstaKlimeId { get; set; }
        public VrstaKlime VrstaKlime { get; set; }


        public int TipVozilaId { get; set; }
        public TipVozila TipVozila { get; set; }


        public int BojaId { get; set; }
        public Boja Boja { get; set; }

        public int BrojVrataId { get; set; }
        public BrojVrata BrojVrata { get; set; }


        public int PogonId { get; set; }
        public Pogon Pogon { get; set; }


        public int EmisioniStandardId { get; set; }
        public EmisioniStandard EmisioniStandard { get; set; }


        public int VrstaSvjetlaId { get; set; }
        public VrstaSvjetla VrstaSvjetla { get; set; }


        public int VrstaKaroserijeId { get; set; }
        public VrstaKaroserije VrstaKaroserije { get; set; }


        //bool area
        
        public bool ABS { get; set; }
        public bool Alarm { get; set; }
        public bool ESP { get; set; }
        public bool Bluetooth { get; set; }
        public bool Maglenke { get; set; }
        public bool Metalik { get; set; }
        public bool Mat { get; set; }
        public bool Tempomat { get; set; }
    }
}

