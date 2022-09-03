using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    public class KupacController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        public KupacController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(KreirajKupcaViewModel registacija)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            jedinicaRada.KupacRepozitorijum.Dodaj(new Kupac() { 
                Ime = registacija.Ime,
                Prezime = registacija.Prezime,
                BrojTelefona = registacija.BrojTelefona,
                KorisnickoIme = registacija.KorisnickoIme,
                Email = registacija.Email,
                Lozinka = registacija.Lozinka
            });
            jedinicaRada.Sacuvaj();
            return RedirectToAction("Index", "Prijava");
        }
        public IActionResult Index()
        {
            var user = HttpContext.User;
            Kupac kupac = jedinicaRada.KupacRepozitorijum.PretragaId(Int32.Parse(user.Identity.Name));

            IzmeniKupcaViewModel model = new IzmeniKupcaViewModel()
            {
                Ime = kupac.Ime,
                Prezime = kupac.Prezime,
                BrojTelefona = kupac.BrojTelefona,
                Email = kupac.Email,
                KorisnickoIme = kupac.KorisnickoIme
            };

            return View(model);
        }
        public IActionResult Edit()
        {
            var user = HttpContext.User;
            Kupac kupac = jedinicaRada.KupacRepozitorijum.PretragaId(Int32.Parse(user.Identity.Name));
            
            IzmeniKupcaViewModel model = new IzmeniKupcaViewModel()
            {
                Ime = kupac.Ime,
                Prezime = kupac.Prezime,
                BrojTelefona = kupac.BrojTelefona,
                Email = kupac.Email,
                KorisnickoIme = kupac.KorisnickoIme
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(IzmeniKupcaViewModel model)
        {
            var user = HttpContext.User;
            Kupac kupac = jedinicaRada.KupacRepozitorijum.PretragaId(Int32.Parse(user.Identity.Name));

            if ((model.StaraLozinka is null && model.NovaLozinka is not null) || (model.StaraLozinka is not null && model.NovaLozinka is null))
            {
                ModelState.AddModelError(string.Empty, "Greska pri popunjavanju lozinki.");
                return Edit();
            }
            if (!ModelState.IsValid)
            {
                return Edit();
            }
            if (model.StaraLozinka != kupac.Lozinka && model.NovaLozinka is not null)
            {
                ModelState.AddModelError(string.Empty, "Neispravna stara lozinka.");
                return Edit();
            }
            if (model.StaraLozinka is null && model.NovaLozinka is null)
            {
                kupac.Lozinka = kupac.Lozinka;
            }
            else
            {
                kupac.Lozinka = model.NovaLozinka;
            }
            
            kupac.Ime = model.Ime;
            kupac.Prezime = model.Prezime;
            kupac.BrojTelefona = model.BrojTelefona;
            kupac.Email = model.Email;
            kupac.KorisnickoIme = model.KorisnickoIme;
           

            jedinicaRada.KupacRepozitorijum.Azuriraj(kupac);
            jedinicaRada.Sacuvaj();

            return View("Index",model);
        }
    }
}
