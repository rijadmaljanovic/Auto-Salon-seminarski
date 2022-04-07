using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.Reports
{
    public class ReportVM
    {
        public string Id { get; set; }

        public string Cijena { get; set; }
        public string RegistrovanDo { get; set; }
        public string PredjeniKilometri { get; set; }
        public string Marka { get; set; }
        //foreign key area
        public string ModelId { get; set; }
        public string GorivoId { get; set; }
        public string TransmisijaId { get; set; }
        public string GodinaProizvodnjeId { get; set; }
        public string VrstaMotoraId { get; set; }
        public string TipVozilaId { get; set; }
        public string BojaId { get; set; }
        public string PogonId { get; set; }
        public string EmisioniStandardId { get; set; }


    }
}
