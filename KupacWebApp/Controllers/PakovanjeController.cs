using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    [Authorize]
    public class PakovanjeController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public PakovanjeController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        [Authorize(Roles = "Kupac")]
        public IActionResult Index()
        {
            List<Pakovanje> pakovanja = jedinicaRada.PakovanjeRepozitorijum.VratiSve();
            List<PakovanjeViewModel> pakovanjeViews = new List<PakovanjeViewModel>();
            foreach(Pakovanje p in pakovanja)
            {
                PakovanjeViewModel pakovanjeView = new PakovanjeViewModel()
                {
                    Boja = p.Boja,
                    Cena = p.Cena,
                    Materijal = p.Materijal,
                    Naziv = p.Naziv,
                    Oblik = p.Oblik,
                    Slika = p.Slika
                };
                pakovanjeViews.Add(pakovanjeView);
            }

            return PartialView(pakovanjeViews);
        }
    }
}
