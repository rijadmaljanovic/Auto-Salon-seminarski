using Data_AS.EntityModels.Vozila;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_salon.ViewModels
{
    public class OdaberiMarkuVM
    {
        public int Id{ get; set; }
        public int MarkaVozilaId{ get; set; }
        [NotMapped]
        public List<SelectListItem> MarkeVozila{ get; set; }
    }
}
