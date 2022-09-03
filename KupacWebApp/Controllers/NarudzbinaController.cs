using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    public class NarudzbinaController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public NarudzbinaController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        public IActionResult Index()
        {
            return PartialView("VrstaNarudzbine");
        }
        [HttpPost]
        public IActionResult Index(KreirajNarudzbinuViewModel kreirajNarudzbinu)
        {
            var prodajnaMesta = jedinicaRada.ProdajnoMestoRepozitorijum.VratiSve().ToList();

            kreirajNarudzbinu.ProdajnaMesta = prodajnaMesta.Select(p => new SelectListItem(p.Adresa, p.ProdajnoMestoId.ToString())).ToList();
            return View(kreirajNarudzbinu);
        }
        [HttpPost]
        public IActionResult Create(KreirajNarudzbinuViewModel kreirajNarudzbinu)
        {
           ////NAPRAVI STA NAKON POTVRDE KREIRNJA NARUDZBINE

            return View(kreirajNarudzbinu);
        }
    }
}
