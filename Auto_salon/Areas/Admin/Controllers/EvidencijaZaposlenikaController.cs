using Auto_salon.Helper;
using Auto_salon.ViewModels;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Areas.Admin.Controllers
{
   //[Autorizacija(true, false, false)]
    public class EvidencijaZaposlenikaController : Controller
    {
        private ApplicationDbContext dbcontext;
        private readonly UserManager<Korisnik> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<EvidencijaZaposlenikaController> logger;
        

        public EvidencijaZaposlenikaController(UserManager<Korisnik> userManager, ApplicationDbContext db, 
            ILogger<EvidencijaZaposlenikaController> lg)
        {
            dbcontext = db;
            _userManager = userManager;
            logger = lg;
            //_roleManager = roleManager;
        }

        public IActionResult DodajNovogZaposlenika()
        {
            var m = new DodajZaposlenikaVM { DatumZaposlenja = DateTime.Today };
            return View(m);
        }
        [ValidateAntiForgeryToken]
        public IActionResult SnimiNovogZaposlenika(DodajZaposlenikaVM model)
        {
            var noviKorisnik = new Korisnik
            {
                Ime = model.Ime,
                Prezime = model.Prezime,
                UserName = model.UserName,
                Email = model.Email,
                EmailConfirmed = true,
                PhoneNumber = model.Telefon,
                PhoneNumberConfirmed = true
            };
            IdentityResult result = _userManager.CreateAsync(noviKorisnik, model.Password).Result;
            if (!result.Succeeded)
            {
                return BadRequest("Greska");
            }
            var noviZaposlenik = new Zaposlenik
            {
                Korisnik = noviKorisnik,
                Adresa = model.Adresa,
                JMBG = model.JMBG,
                DatumZaposlenja = model.DatumZaposlenja
            };
            dbcontext.Add(noviZaposlenik);
            dbcontext.SaveChanges();
            return RedirectToAction("SviZaposlenici");
        }
        public IActionResult SviZaposlenici()
        {
                var zaposlenici = dbcontext.Zaposlenik.Select(s => new SviZaposleniciVM
                {
                    Id = s.Id.ToString(),
                    Ime = s.Korisnik.Ime,
                    Prezime = s.Korisnik.Prezime,
                    Email = s.Korisnik.Email,
                    Telefon = s.Korisnik.PhoneNumber,
                    Adresa = s.Adresa
                }).ToList();

                return View(zaposlenici);
           
        }
        public IActionResult UrediZaposlenika(int zaposlenikId)
        {
            var zaposlenik = dbcontext.Zaposlenik.Select(s =>
            new UrediZaposlenikaVM
            {
                ZaposlenikId = s.Id.ToString(),
                Ime = s.Korisnik.Ime,
                Prezime = s.Korisnik.Prezime,
                Telefon = s.Korisnik.PhoneNumber,
                JMBG = s.JMBG,
                Email=s.Korisnik.Email,
                Adresa = s.Adresa,
                DatumZaposlenja = s.DatumZaposlenja.ToString()
            }).FirstOrDefault(x => x.ZaposlenikId == zaposlenikId.ToString());
            return View(zaposlenik);
        }

        [ValidateAntiForgeryToken]
        public IActionResult SpremiUredjenogZaposlenika(UrediZaposlenikaVM model)
        {
            var zaposlenik = dbcontext.Zaposlenik.Include(z=>z.Korisnik).FirstOrDefault(z=>z.Id.ToString()==model.ZaposlenikId);
            zaposlenik.Adresa = model.Adresa;
            zaposlenik.JMBG = model.JMBG;
            zaposlenik.Korisnik.Email=model.Email;
            zaposlenik.Korisnik.PhoneNumber= model.Telefon;
            zaposlenik.Korisnik.Ime = model.Ime;
            zaposlenik.Korisnik.Prezime = model.Prezime;

            dbcontext.Zaposlenik.Update(zaposlenik);
            dbcontext.SaveChanges();
            return RedirectToAction("SviZaposlenici");
        }
        public IActionResult ObrisiZaposlenika(string zaposlenikId)
        {
            var zaposlenik = dbcontext.Zaposlenik.Include(z => z.Korisnik).FirstOrDefault(z => z.Id.ToString() == zaposlenikId);
            dbcontext.Remove(zaposlenik);
            dbcontext.SaveChanges();

            return RedirectToAction("SviZaposlenici");
        }
        public IActionResult PretragaZaposlenika(string filter)
        {
            var zaposlenici = dbcontext.Zaposlenik.Where(x => x.Korisnik.Ime == filter).Select(s => new SviZaposleniciVM
            {
                Id = s.Id.ToString(),
                Ime = s.Korisnik.Ime,
                Prezime = s.Korisnik.Prezime,
                Email = s.Korisnik.Email,
                Telefon = s.Korisnik.PhoneNumber,
                Adresa = s.Adresa
            }).ToList();

            return View("SviZaposlenici", zaposlenici);

        }
    }

}
