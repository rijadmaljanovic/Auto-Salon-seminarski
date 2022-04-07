﻿using Auto_salon.Helper;
using Data_AS.EntityModels.Korisnici;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace Auto_salon.Areas.Admin.Controllers
{
    [Autorizacija(true, false, false)]
    public class AdminHomeController : Controller
    {
        private ApplicationDbContext dbcontext;
        private readonly UserManager<Korisnik> _userManager;
        private readonly ILogger<AdminHomeController> logger;
        public AdminHomeController(UserManager<Korisnik> userManager, ApplicationDbContext db,
           ILogger<AdminHomeController> lg)
        {
            dbcontext = db;
            _userManager = userManager;
            logger = lg;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
