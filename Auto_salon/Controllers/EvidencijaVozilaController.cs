using Auto_salon.ViewModels;
using Data_AS.EntityModels.Korisnici;
using Data_AS.EntityModels.Vozila;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using X.PagedList;

namespace Auto_salon.Controllers
{
    public class EvidencijaVozilaController : Controller
    {
        private ApplicationDbContext dbContext;
        private readonly UserManager<Korisnik> _userManager;
        public EvidencijaVozilaController(UserManager<Korisnik> userManager, ApplicationDbContext db)
        {
            dbContext = db;
            _userManager = userManager;
        }
        public IActionResult Index(int i=1)
        {
            var model = dbContext.Vozilo.Select(s => new PrikazVozila
            {
                Id=s.Id,
                Model=s.Model.Naziv,
                Marka=s.Marka,
                Transmisija=s.Transmisija.Naziv,
                Cijena=s.Cijena,
                GodinaProizvodnje=s.GodinaProizvodnje.Godina
            }).ToList().ToPagedList(i ,6);

            return View(model);
        }

        public IActionResult PretragaVozila(string filter, int i=1)
        {
            var vozilaFilter = dbContext.Vozilo.Where(x => x.Marka == filter).Select(s => new PrikazVozila
            {
                Id = s.Id,
                Model = s.Model.Naziv,
                Marka = s.Marka,
                Transmisija = s.Transmisija.Naziv,
                Cijena = s.Cijena,
                GodinaProizvodnje = s.GodinaProizvodnje.Godina
            }).ToList().ToPagedList(i, 6);

            return View("Index", vozilaFilter);

        }
        [HttpGet]
        public IActionResult DodajVozilo()
        {
            DodajVoziloVM model = new DodajVoziloVM();

            model.Modeli = dbContext.ModelVozila.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.BrojStepeniPrijenosa = dbContext.BrojStepeniPrijenosa.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Gorivo = dbContext.Gorivo.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Transmisija = dbContext.Transmisija.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.GodinaProizvodnje = dbContext.GodinaProizvodnje.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Godina.ToString()
            }).ToList();

            model.ParkingSenzor = dbContext.ParkingSenzor.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaMotora = dbContext.VrstaMotora.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaKlime = dbContext.VrstaKlime.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.TipVozila = dbContext.TipVozila.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Boja = dbContext.Boja.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.BrojVrata = dbContext.BrojVrata.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Pogon = dbContext.Pogon.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.EmisioniStandard = dbContext.EmisioniStandard.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaSvjetla = dbContext.VrstaSvjetla.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaKaroserije = dbContext.VrstaKaroserije.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            return PartialView("DodajNovoVozilo", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SnimiNovoVozilo(DodajVoziloVM voziloModel)
        {
            Vozilo novoVozilo = new Vozilo
            {
                Cijena = voziloModel.Cijena,
                RegistrovanDo = voziloModel.RegistrovanDo,
                PredjeniKilometri = voziloModel.PredjeniKilometri,
                SnagaMotoraKW = voziloModel.SnagaMotoraKW,
                SnagaMotoraKS = voziloModel.SnagaMotoraKS,
                Kubikaza = voziloModel.Kubikaza,
                Marka = voziloModel.Marka,

                ModelId = voziloModel.ModelId,
                BrojStepeniPrijenosaId = voziloModel.BrojStepeniPrijenosaId,
                GorivoId = voziloModel.GorivoId,
                TransmisijaId = voziloModel.TransmisijaId,
                GodinaProizvodnjeId = voziloModel.GodinaProizvodnjeId,
                ParkingSenzorId = voziloModel.ParkingSenzorId,
                VrstaMotoraId = voziloModel.VrstaMotoraId,
                VrstaKlimeId = voziloModel.VrstaKlimeId,
                TipVozilaId = voziloModel.TipVozilaId,
                BojaId = voziloModel.BojaId,
                BrojVrataId = voziloModel.BrojVrataId,
                PogonId = voziloModel.PogonId,
                EmisioniStandardId = voziloModel.EmisioniStandardId,
                VrstaSvjetlaId = voziloModel.VrstaSvjetlaId,
                VrstaKaroserijeId = voziloModel.VrstaKaroserijeId,

                ABS = voziloModel.ABS,
                Alarm = voziloModel.Alarm,
                ESP = voziloModel.ESP,
                Bluetooth = voziloModel.Bluetooth,
                Maglenke = voziloModel.Maglenke,
                Metalik = voziloModel.Metalik,
                Mat = voziloModel.Mat,
                Tempomat = voziloModel.Tempomat
            };

            dbContext.Add(novoVozilo);
            dbContext.SaveChanges();
            UcitajSlike(voziloModel, novoVozilo.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UrediVozilo(int id)
        {
            var vozilo = dbContext.Vozilo.Find(id);

            var model = new UrediVoziloVM
            {
                Id = vozilo.Id,
                ModelId = vozilo.ModelId,
                Cijena = vozilo.Cijena,
                RegistrovanDo = vozilo.RegistrovanDo,
                PredjeniKilometri = vozilo.PredjeniKilometri,
                SnagaMotoraKS = vozilo.SnagaMotoraKS,
                SnagaMotoraKW = vozilo.SnagaMotoraKW,
                Kubikaza = vozilo.Kubikaza,
                Marka = vozilo.Marka,
                ABS = vozilo.ABS,
                Alarm = vozilo.Alarm,
                ESP = vozilo.ESP,
                Bluetooth = vozilo.Bluetooth,
                Maglenke = vozilo.Maglenke,
                Metalik = vozilo.Metalik,
                Mat = vozilo.Mat,
                Tempomat = vozilo.Tempomat,

                BrojStepeniPrijenosaId = vozilo.BrojStepeniPrijenosaId,
                GorivoId = vozilo.GorivoId,
                TransmisijaId = vozilo.TransmisijaId,
                GodinaProizvodnjeId = vozilo.GodinaProizvodnjeId,
                ParkingSenzorId = vozilo.ParkingSenzorId,
                VrstaMotoraId = vozilo.VrstaMotoraId,
                VrstaKlimeId = vozilo.VrstaKlimeId,
                TipVozilaId = vozilo.TipVozilaId,
                BojaId = vozilo.BojaId,
                BrojVrataId = vozilo.BrojVrataId,
                PogonId = vozilo.PogonId,
                EmisioniStandardId = vozilo.EmisioniStandardId,
                VrstaSvjetlaId = vozilo.VrstaSvjetlaId,
                VrstaKaroserijeId = vozilo.VrstaKaroserijeId
            };

            model.Modeli = dbContext.ModelVozila.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.BrojStepeniPrijenosa = dbContext.BrojStepeniPrijenosa.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Gorivo = dbContext.Gorivo.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Transmisija = dbContext.Transmisija.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.GodinaProizvodnje = dbContext.GodinaProizvodnje.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Godina.ToString()
            }).ToList();

            model.ParkingSenzor = dbContext.ParkingSenzor.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaMotora = dbContext.VrstaMotora.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaKlime = dbContext.VrstaKlime.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.TipVozila = dbContext.TipVozila.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Boja = dbContext.Boja.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.BrojVrata = dbContext.BrojVrata.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.Pogon = dbContext.Pogon.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.EmisioniStandard = dbContext.EmisioniStandard.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaSvjetla = dbContext.VrstaSvjetla.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            model.VrstaKaroserije = dbContext.VrstaKaroserije.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Naziv
            }).ToList();

            return PartialView("UrediVozilo",model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SnimiUredjenoVozilo(UrediVoziloVM carModel)
        {
            var vozilo = dbContext.Vozilo.FirstOrDefault(z => z.Id == carModel.Id);

            vozilo.Cijena = carModel.Cijena;
            vozilo.RegistrovanDo = carModel.RegistrovanDo;
            vozilo.PredjeniKilometri = carModel.PredjeniKilometri;
            vozilo.SnagaMotoraKW = carModel.SnagaMotoraKW;
            vozilo.SnagaMotoraKS = carModel.SnagaMotoraKS;
            vozilo.Kubikaza = carModel.Kubikaza;
            vozilo.Marka = carModel.Marka;

            vozilo.ModelId = carModel.ModelId;
            vozilo.BrojStepeniPrijenosaId = carModel.BrojStepeniPrijenosaId;
            vozilo.GorivoId = carModel.GorivoId;
            vozilo.TransmisijaId = carModel.TransmisijaId;
            vozilo.GodinaProizvodnjeId = carModel.GodinaProizvodnjeId;
            vozilo.ParkingSenzorId = carModel.ParkingSenzorId;
            vozilo.VrstaMotoraId = carModel.VrstaMotoraId;
            vozilo.VrstaKlimeId = carModel.VrstaKlimeId;
            vozilo.TipVozilaId = carModel.TipVozilaId;
            vozilo.BojaId = carModel.BojaId;
            vozilo.BrojVrataId = carModel.BrojVrataId;
            vozilo.PogonId = carModel.PogonId;
            vozilo.EmisioniStandardId = carModel.EmisioniStandardId;
            vozilo.VrstaSvjetlaId = carModel.VrstaSvjetlaId;
            vozilo.VrstaKaroserijeId = carModel.VrstaKaroserijeId;

            vozilo.ABS = carModel.ABS;
            vozilo.Alarm = carModel.Alarm;
            vozilo.ESP = carModel.ESP;
            vozilo.Bluetooth = carModel.Bluetooth;
            vozilo.Maglenke = carModel.Maglenke;
            vozilo.Metalik = carModel.Metalik;
            vozilo.Mat = carModel.Mat;
            vozilo.Tempomat = carModel.Tempomat;

            dbContext.Vozilo.Update(vozilo);
            dbContext.SaveChanges();


            return RedirectToAction("Index");
        }

        public IActionResult ObrisiVozilo(int voziloId)
        {
            var vozilo = dbContext.Vozilo.FirstOrDefault(z => z.Id == voziloId);
            dbContext.Remove(vozilo);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DetaljiVozila(int id)
        {
            var vozilo = dbContext.Vozilo.Find(id);

            var modelVozilo = dbContext.ModelVozila.FirstOrDefault(s => s.Id == vozilo.ModelId);
            var BrojStepeniPrijenosa = dbContext.BrojStepeniPrijenosa.FirstOrDefault(s => s.Id == vozilo.BrojStepeniPrijenosaId);
            var GorivoId = dbContext.Gorivo.FirstOrDefault(s => s.Id == vozilo.GorivoId);
            var TransmisijaId = dbContext.Transmisija.FirstOrDefault(s => s.Id == vozilo.TransmisijaId);
            var GodinaProizvodnjeId = dbContext.GodinaProizvodnje.FirstOrDefault(s => s.Id == vozilo.GodinaProizvodnjeId);
            var ParkingSenzorId = dbContext.ParkingSenzor.FirstOrDefault(s => s.Id == vozilo.ParkingSenzorId);
            var VrstaMotoraId = dbContext.VrstaMotora.FirstOrDefault(s => s.Id == vozilo.VrstaMotoraId);
            var VrstaKlimeId = dbContext.VrstaKlime.FirstOrDefault(s => s.Id == vozilo.VrstaKlimeId);
            var TipVozilaId = dbContext.TipVozila.FirstOrDefault(s => s.Id == vozilo.TipVozilaId);
            var BojaId = dbContext.Boja.FirstOrDefault(s => s.Id == vozilo.BojaId);
            var BrojVrataId = dbContext.BrojVrata.FirstOrDefault(s => s.Id == vozilo.BrojVrataId);
            var PogonId = dbContext.Pogon.FirstOrDefault(s => s.Id == vozilo.PogonId);
            var EmisioniStandardId = dbContext.EmisioniStandard.FirstOrDefault(s => s.Id == vozilo.EmisioniStandardId);
            var VrstaSvjetlaId = dbContext.VrstaSvjetla.FirstOrDefault(s => s.Id == vozilo.VrstaSvjetlaId);
            var VrstaKaroserijeId = dbContext.VrstaKaroserije.FirstOrDefault(s => s.Id == vozilo.VrstaKaroserijeId);

            var model = new DetaljiVozilaVM
            {
                BrojStepeniPrijenosaId = BrojStepeniPrijenosa.Naziv,
                GorivoId = GorivoId.Naziv,
                TransmisijaId = TransmisijaId.Naziv,
                GodinaProizvodnjeId = GodinaProizvodnjeId.Godina,
                ParkingSenzorId = ParkingSenzorId.Naziv,
                VrstaMotoraId = VrstaMotoraId.Naziv,
                VrstaKlimeId = VrstaKlimeId.Naziv,
                TipVozilaId = TipVozilaId.Naziv,
                BojaId = BojaId.Naziv,
                BrojVrataId = BrojVrataId.Naziv,
                PogonId = PogonId.Naziv,
                EmisioniStandardId = EmisioniStandardId.Naziv,
                VrstaSvjetlaId = VrstaSvjetlaId.Naziv,
                VrstaKaroserijeId = VrstaKaroserijeId.Naziv,
                ModelId = modelVozilo.Naziv,

                Id = vozilo.Id,
                Cijena = vozilo.Cijena,
                RegistrovanDo = vozilo.RegistrovanDo,
                PredjeniKilometri = vozilo.PredjeniKilometri,
                SnagaMotoraKS = vozilo.SnagaMotoraKS,
                SnagaMotoraKW = vozilo.SnagaMotoraKW,
                Kubikaza = vozilo.Kubikaza,
                Marka = vozilo.Marka,
                ABS = vozilo.ABS,
                Alarm = vozilo.Alarm,
                ESP = vozilo.ESP,
                Bluetooth = vozilo.Bluetooth,
                Maglenke = vozilo.Maglenke,
                Metalik = vozilo.Metalik,
                Mat = vozilo.Mat,
                Tempomat = vozilo.Tempomat,

                
            };
            var carImageSET = dbContext.VoziloImage.Where(x => x.VoziloId == id).ToList();
            var AllImages = new List<string>();

            foreach (var slika in carImageSET)
            {
                AllImages.Add(dbContext.Image.Where(x => x.Id == slika.Id).Select(i => i.PathToImage).FirstOrDefault());
            }
            model.images = AllImages;
            return PartialView("DetaljiVozila",model);
        }
        private void UcitajSlike(DodajVoziloVM model, int carID)
        {
            List<string> jedinstvenaImenaSlika = new List<string>();

            if (model.Images != null)
            {
                string folder = "wwwroot/Images/";
                bool exists = System.IO.Directory.Exists(folder);
                if (!exists)
                    System.IO.Directory.CreateDirectory(folder);

                foreach (var item in model.Images)
                {
                    string ekstenzija = Path.GetExtension(item.FileName);

                    var filename = $"{Guid.NewGuid()}{ekstenzija}";

                    item.CopyTo(new FileStream(folder + filename, FileMode.Create));

                    var image = new Image();
                    image.PathToImage = "/Images/" + filename;

                    jedinstvenaImenaSlika.Add(image.PathToImage);

                    dbContext.Add(image);
                    dbContext.SaveChanges();

                    dbContext.Add(new VoziloImage
                    {
                        VoziloId = carID,
                        ImageID = image.Id
                    });

                    dbContext.SaveChanges();
                }
            }
        }
        
    }

}
