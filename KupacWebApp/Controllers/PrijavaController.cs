using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Security.Claims;

namespace KupacWebApp.Controllers
{
    public class PrijavaController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public PrijavaController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PrijavaViewModel prijava)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            Kupac k = jedinicaRada.KupacRepozitorijum.PretragaKorisnickoImeLozinka(prijava.KorisnickoIme, prijava.Lozinka);

            if (k != null)
            {
                Dictionary<string, string> claims = new Dictionary<string, string>();
                claims.Add(ClaimTypes.Role, k.GetType().Name);
                claims.Add(ClaimTypes.Name, k.KupacId.ToString());

                HttpContext.Session.Set("Identity", JsonSerializer.SerializeToUtf8Bytes(claims));

                return RedirectToAction("Index", "Pocetna");
            }
            ModelState.AddModelError(string.Empty, "Korisnik ne postoji!");

            return View();
        }
    }
}
