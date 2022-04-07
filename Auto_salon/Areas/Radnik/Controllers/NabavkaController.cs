using Auto_salon.ViewModels;
using Data_AS.EntityModels.Korisnici;
using Data_AS.EntityModels.Vozila;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Areas.Radnik.Controllers
{
    public class NabavkaController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<Korisnik> _userManager;
        private readonly ILogger<RadnikHomeController> logger;
        public NabavkaController(UserManager<Korisnik> userManager, ApplicationDbContext db,
           ILogger<RadnikHomeController> lg)
        {
            _context = db;
            _userManager = userManager;
            logger = lg;
            //_roleManager = roleManager;
        }

        public IActionResult OdaberiMarku()
        {
            //var m = new OdaberiMarkuVM
            //{
            //    MarkeVozila = _context.MarkaVozila
            //    .Select
            //    (
            //        i => new SelectListItem
            //        {
            //            Value = i.Id.ToString(),
            //            Text = i.Naziv
            //        }
            //    )
            //    .ToList()
            //};
            return View();
        }
        //public IActionResult DodajDetalje(OdaberiMarkuVM vm)
        //{
        //    var voziloNovo = new Vozilo();
        //    var modeli = _context.ModelVozila.Where(x => x.MarkaId == vm.MarkaVozilaId).ToList();
        //    var m = new DodajDetaljeVM
        //    {

        //    };
        //}
    }
}
