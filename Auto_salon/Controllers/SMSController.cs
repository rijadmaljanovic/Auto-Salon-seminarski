using Auto_salon.ViewModels;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Controllers
{
    public class SMSController : Controller
    {
        private ApplicationDbContext _ctx;
        private readonly UserManager<Korisnik> _userManager;
        public SMSController(ApplicationDbContext ctx, UserManager<Korisnik> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
   
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage(SMSMessageVM message)
        {

            var results = SMS.Send(new SMS.SMSRequest
            {
                from = Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],
                to = message.To,
                text = message.ContentMsg
            });
            return Redirect("/EvidencijaVozila/Index");
        }
    }
}
