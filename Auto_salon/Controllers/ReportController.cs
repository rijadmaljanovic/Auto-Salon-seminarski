using AspNetCore.Reporting;
using Auto_salon.Reports;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Controllers
{
    public class ReportController : Controller
    {
        private ApplicationDbContext dbContext;
        private readonly UserManager<Korisnik> _userManager;
        public ReportController(UserManager<Korisnik> userManager, ApplicationDbContext db)
        {
            dbContext = db;
            _userManager = userManager;
        }
        public static List<ReportVM> getCar(ApplicationDbContext db, int voziloId)
        {
            var vozilo = db.Vozilo.Find(voziloId);

            var modelVozilo = db.ModelVozila.FirstOrDefault(s => s.Id == vozilo.ModelId);
            var BrojStepeniPrijenosa = db.BrojStepeniPrijenosa.FirstOrDefault(s => s.Id == vozilo.BrojStepeniPrijenosaId);
            var GorivoId = db.Gorivo.FirstOrDefault(s => s.Id == vozilo.GorivoId);
            var TransmisijaId = db.Transmisija.FirstOrDefault(s => s.Id == vozilo.TransmisijaId);
            var GodinaProizvodnjeId = db.GodinaProizvodnje.FirstOrDefault(s => s.Id == vozilo.GodinaProizvodnjeId);
            var ParkingSenzorId = db.ParkingSenzor.FirstOrDefault(s => s.Id == vozilo.ParkingSenzorId);
            var VrstaMotoraId = db.VrstaMotora.FirstOrDefault(s => s.Id == vozilo.VrstaMotoraId);
            var VrstaKlimeId = db.VrstaKlime.FirstOrDefault(s => s.Id == vozilo.VrstaKlimeId);
            var TipVozilaId = db.TipVozila.FirstOrDefault(s => s.Id == vozilo.TipVozilaId);
            var BojaId = db.Boja.FirstOrDefault(s => s.Id == vozilo.BojaId);
            var BrojVrataId = db.BrojVrata.FirstOrDefault(s => s.Id == vozilo.BrojVrataId);
            var PogonId = db.Pogon.FirstOrDefault(s => s.Id == vozilo.PogonId);
            var EmisioniStandardId = db.EmisioniStandard.FirstOrDefault(s => s.Id == vozilo.EmisioniStandardId);
            var VrstaSvjetlaId = db.VrstaSvjetla.FirstOrDefault(s => s.Id == vozilo.VrstaSvjetlaId);
            var VrstaKaroserijeId = db.VrstaKaroserije.FirstOrDefault(s => s.Id == vozilo.VrstaKaroserijeId);

            List<ReportVM> podaci = db.Vozilo
                .Where(w => w.Id == voziloId)
                .Select(s => new ReportVM
                {
                    GorivoId = GorivoId.Naziv,
                    TransmisijaId = TransmisijaId.Naziv,
                    GodinaProizvodnjeId = GodinaProizvodnjeId.Godina.ToString(),
                    VrstaMotoraId = VrstaMotoraId.Naziv,
                    TipVozilaId = TipVozilaId.Naziv,
                    BojaId = BojaId.Naziv,
                    PogonId = PogonId.Naziv,
                    EmisioniStandardId = EmisioniStandardId.Naziv,
                    ModelId = modelVozilo.Naziv,

                    Id = vozilo.Id.ToString(),
                    RegistrovanDo = vozilo.RegistrovanDo.ToString(),
                    PredjeniKilometri = vozilo.PredjeniKilometri.ToString(),
                    Marka = vozilo.Marka,
                    Cijena = vozilo.Cijena.ToString() + " KM"

                }).ToList();

            return podaci;
        }
        public IActionResult Index(int voziloId)
        {
            AspNetCore.Reporting.LocalReport _localReport = new AspNetCore.Reporting.LocalReport("Reports/Report.rdlc");
            List<ReportVM> podaci = getCar(dbContext, voziloId);
            _localReport.AddDataSource("DataSet2", podaci);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            ReportResult result = _localReport.Execute(RenderType.Pdf, parameters: parameters);
            return File(result.MainStream, "application/pdf");
        }
    }
}