using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Domen;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace KupacWebApp.Controllers
{
  
    public class PocetnaController : Controller
    {
        private readonly UserManager<Osoba> manager;

        public PocetnaController(UserManager<Osoba> manager)
        {
            this.manager = manager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (HttpContext.User.IsInRole("Kupac"))
            {
                return RedirectToAction("KupacProfil", "Pocetna");
            }
            return View();
        }
        [Authorize(Roles = "Kupac")]
        public IActionResult KupacProfil()
        {
            var userId = manager.GetUserId(HttpContext.User);
            Osoba currentUser = manager.FindByIdAsync(userId).Result;
            IzmeniKupcaViewModel kupac = new IzmeniKupcaViewModel()
            {
                Ime = currentUser.Ime,
                Email = currentUser.Email,
                KorisnickoIme = currentUser.UserName,
                BrojTelefona = currentUser.PhoneNumber,
                Prezime = currentUser.Prezime,
            };
            return View(kupac);
        }
    }
}
