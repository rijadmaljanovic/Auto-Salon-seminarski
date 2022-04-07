using System.Linq;
using Data_AS.EntityModels;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Data;

namespace Auto_salon.Helper
{
    public static class Autentifikacija
    {
        public static Korisnik LogiraniKorisnik(this HttpContext httpContext)
        {
            //Preuzimamo DbContext preko app services
            ApplicationDbContext db = httpContext.RequestServices.GetService<ApplicationDbContext>();

            //Preuzimamo userManager preko app services
            UserManager<Korisnik> userManager = httpContext.RequestServices.GetService<UserManager<Korisnik>>();

            if (httpContext.User == null)
                return null;

            //TrenutniKorisnikID
            string userId = userManager.GetUserId(httpContext.User);

            Korisnik k = db.Korisnik.Where(s => s.Id == userId)
                .Include(s => s.Administrator)
                .Include(s => s.Zaposlenik)
                .Include(s => s.Klijent)
                .SingleOrDefault();

            return k;
        }
    }
}
