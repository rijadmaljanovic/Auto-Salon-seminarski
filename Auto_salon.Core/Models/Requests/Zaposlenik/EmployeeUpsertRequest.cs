using System;

namespace MusicApplication.Requests.Zaposlenik
{
    public class EmployeeUpsertRequest
    {
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Adresa { get; set; }
        public string Ime { get; set; }
        public string Jmbg { get; set; }
        public string Kanton { get; set; }
        public int GodinaZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public int KategorijaId { get; set; }
    }
}
