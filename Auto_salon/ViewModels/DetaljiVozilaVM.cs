using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class DetaljiVozilaVM
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

        public string ModelId { get; set; }
        public string BrojStepeniPrijenosaId { get; set; }
        public string GorivoId { get; set; }
        public string TransmisijaId { get; set; }
        public int? GodinaProizvodnjeId { get; set; }
        public string ParkingSenzorId { get; set; }
        public string VrstaMotoraId { get; set; }


        public string VrstaKlimeId { get; set; }


        public string TipVozilaId { get; set; }


        public string BojaId { get; set; }

        public string BrojVrataId { get; set; }

        public string PogonId { get; set; }

        public string EmisioniStandardId { get; set; }

        public string VrstaSvjetlaId { get; set; }

        public string VrstaKaroserijeId { get; set; }


        public List<string> images { get; set; }
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
