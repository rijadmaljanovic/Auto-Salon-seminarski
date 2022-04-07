using System;

namespace MusicApplication.Core.Models
{
    public class ZaposlenikModel
    {
        public int Id { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Ime { get; set; }
        public string Jmbg { get; set; }
        public string Adresa { get; set; }
        public int GodinaZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }
    }
}
