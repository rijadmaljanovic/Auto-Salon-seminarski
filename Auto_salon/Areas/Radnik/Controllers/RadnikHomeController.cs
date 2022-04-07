using Auto_salon.Helper;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Areas.Radnik.Controllers
{
    [Autorizacija(false, true, false)]
    public class RadnikHomeController : Controller
    {
        private ApplicationDbContext dbcontext;
        private readonly UserManager<Korisnik> _userManager;
        private readonly ILogger<RadnikHomeController> logger;
        public RadnikHomeController(UserManager<Korisnik> userManager, ApplicationDbContext db,
           ILogger<RadnikHomeController> lg)
        {
            dbcontext = db;
            _userManager = userManager;
            logger = lg;
            //_roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
