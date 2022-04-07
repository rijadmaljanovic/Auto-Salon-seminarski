using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicApp.Core.Entities
{
    public class Kategorija
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Zaposlenik> Zaposleniks { get; set; }
    }
}
