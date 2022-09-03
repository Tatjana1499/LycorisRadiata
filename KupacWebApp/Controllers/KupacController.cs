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
            return View();
        }
    }
}
