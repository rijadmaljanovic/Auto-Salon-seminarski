using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicApp.Core.Entities
{
    public class Zaposlenik
    {
        [Key]
        public int Id { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Ime { get; set; }
        public string Jmbg { get; set; }
        public string Adresa { get; set; }
        public int GodinaZaposlenja { get; set; }
        public bool Aktivan { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
