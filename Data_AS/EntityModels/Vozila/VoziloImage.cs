using System;
using System.Collections.Generic;
using System.Text;

namespace Data_AS.EntityModels.Vozila
{
    public class VoziloImage
    {
        public int Id { get; set; }
        public int VoziloId { get; set; }
        public Vozilo Vozilo{ get; set; }
        public int ImageID { get; set; }
        public Image Image { get; set; }
    }
}
