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
            else if (HttpContext.User.IsInRole("Administrator"))
            {
                return RedirectToAction("AdministratorProfil", "Pocetna");
            }
            PocetnaViewModel model = new PocetnaViewModel()
            {
                Motiv = System.IO.File.ReadAllText("../KupacWebApp/wwwroot/text/motiv.txt"),
                Istorijat = System.IO.File.ReadAllText("../KupacWebApp/wwwroot/text/istorijat.txt"),
                KupciRekli = System.IO.File.ReadAllText("../KupacWebApp/wwwroot/text/iskustva.txt"),
                Kontakt = System.IO.File.ReadAllLines("../KupacWebApp/wwwroot/text/kontakt.txt")
        };
            
            return View(model);
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
        [Authorize(Roles = "Administrator")]
        public IActionResult AdministratorProfil()
        {
            var userId = manager.GetUserId(HttpContext.User);
            Administrator currentUser = (Administrator)  manager.FindByIdAsync(userId).Result;
            
            AdministratorViewModel administrator = new AdministratorViewModel()
            {
                Ime = currentUser.Ime,
                KorisnickoIme = currentUser.UserName,
                Email = currentUser.Email,
                Prezime = currentUser.Prezime,
                DatumZaposlenja = currentUser.DatumZaposlenja,
                SifraZaposlenog = currentUser.SifraZaposlenog

            };

            return View(administrator);
        }
    }
}
