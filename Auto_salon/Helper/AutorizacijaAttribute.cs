using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Data_AS.EntityModels;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Auto_salon.Helper
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool dozvoljenoAdminu, bool dozvoljenoZaposleniku,bool dozvoljenoKlijentu)
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] { dozvoljenoAdminu, dozvoljenoZaposleniku, dozvoljenoKlijentu };
        }
    }


    public class MyAuthorizeImpl : IActionFilter
    {
        public MyAuthorizeImpl(bool dozvoljenoAdminu, bool dozvoljenoZaposleniku, bool dozvoljenoKlijentu)
        {
            _dozvoljenoAdminu = dozvoljenoAdminu;
            _dozvoljenoZaposleniku = dozvoljenoZaposleniku;
            _dozvoljenoKlijentu = dozvoljenoKlijentu;
        }
        private readonly bool _dozvoljenoAdminu;
        private readonly bool _dozvoljenoZaposleniku;
        private readonly bool _dozvoljenoKlijentu;

        public void OnActionExecuted(ActionExecutedContext context)
        {


        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext httpContext = filterContext.HttpContext;

            Korisnik k = httpContext.LogiraniKorisnik();

            if (k == null)
            {
                if (filterContext.Controller is Controller controller)
                {
                    controller.TempData["PorukaError"] = "Niste logirani";
                }
                filterContext.Result = new RedirectResult("/Identity/Account/Login");
                return;
            }

            //KretanjePoSistemu.Save(httpContext);

            //administratori mogu pristupiti 
            if (_dozvoljenoAdminu && k.Administrator != null)
            {
                return;//ok - ima pravo pristupa
            }

            //zaposlenici mogu pristupiti 
            if (_dozvoljenoZaposleniku && k.Zaposlenik != null)
            {
                return;//ok - ima pravo pristupa
            }
            if (_dozvoljenoKlijentu && k.Klijent != null)
            {
                return;//ok - ima pravo pristupa
            }

            if (filterContext.Controller is Controller c1)
            {
                c1.ViewData["PorukaError"] = "Nemate pravo pristupa";
            }
            filterContext.Result = new RedirectResult("/");
        }
    }
}
