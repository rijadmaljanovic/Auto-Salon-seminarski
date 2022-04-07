using Auto_salon.Models;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<Korisnik> _userManager;
        private SignInManager<Korisnik> _signInManager;
        private ApplicationDbContext applicationdbcontext;

        public HomeController(ILogger<HomeController> logger, UserManager<Korisnik> userManager, SignInManager<Korisnik> signInManager, ApplicationDbContext _applicationdbcontext)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            applicationdbcontext = _applicationdbcontext;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var admin = applicationdbcontext.Administrator.Where(a => a.KorisnikId == user.Id).FirstOrDefault();
                var zaposlenik = applicationdbcontext.Zaposlenik.Where(a => a.KorisnikId == user.Id).FirstOrDefault();

                if (admin != null)
                {
                    var administrator = applicationdbcontext.Korisnik.FirstOrDefault(s => s.Id == admin.KorisnikId);
                    if (administrator.Email == "admin@gmail.com")
                    {
                        return Redirect(url: "/AdminHome/Index");
                    }
                }

                if (zaposlenik!=null)
                {
                    var employee = applicationdbcontext.Korisnik.FirstOrDefault(s => s.Id == zaposlenik.KorisnikId);
                        if (employee.Email == "test@gmail.com")
                        {
                            return Redirect(url: "/evidencijavozila");
                        }
                }

                if (admin != null)
                {
                    return Redirect(url: "/AdminHome/Index");
                }
                else
                {
                    return Redirect(url: "/evidencijavozila");
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
