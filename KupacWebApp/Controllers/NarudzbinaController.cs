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
        public IActionResult VrstaNarudzbine()
        {
            return PartialView();
        }
        public IActionResult DodajProizvod(int proizvodId, string Naziv, int RedniBroj)
        {
            StavkaViewModel model = new StavkaViewModel()
            {
                ProizvodId = proizvodId,
                Naziv = Naziv,
                RedniBroj = RedniBroj
            };

            return PartialView(model);
        }
        [HttpGet]
        public IActionResult Create(KreirajNarudzbinuViewModel kreirajNarudzbinu)
        {
            List<Proizvod> proizvodi = jedinicaRada.ProizvodRepozitorijum.VratiSve();
            var prodajnaMesta = jedinicaRada.ProdajnoMestoRepozitorijum.VratiSve().ToList();
            List<ProizvodViewModel> proizvodiView = new List<ProizvodViewModel>();
            foreach(Proizvod proizvod in proizvodi)
            {
                ProizvodViewModel proizvodView = new ProizvodViewModel()
                {
                    ProizvodId = proizvod.ProizvodId,
                    Naziv = proizvod.Naziv,
                    Cena = proizvod.Cena
                };
                if(proizvod.GetType() == typeof(Cvet)) proizvodView.JesteCvet = true;
                proizvodiView.Add(proizvodView);
            }
            kreirajNarudzbinu.Proizvodi = proizvodiView;
            kreirajNarudzbinu.ProdajnaMesta = prodajnaMesta.Select(p => new SelectListItem(p.Adresa, p.ProdajnoMestoId.ToString())).ToList();
            return View("Create", kreirajNarudzbinu);
        }
        [HttpPost]
        public IActionResult CreateP(KreirajNarudzbinuViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create(model);
            }
            List<Stavka> stavke = new List<Stavka>();
            foreach (StavkaViewModel stVM in model.Stavke)
            {
                if (stVM.Kolicina > 0)
                {
                    Stavka stavka = new Stavka()
                    {
                        Kolicina = stVM.Kolicina,
                        ProizvodId = stVM.ProizvodId
                    };
                    stavke.Add(stavka);
                }
            }
            if (stavke.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "Prazna narudžbina.");
                return Create(model);
            }
            Narudzbina narudzbina = new Narudzbina()
            {
                Adresa = model.Adresa,
                ProdajnoMestoId = model.ProdajnoMestoId,
                KupacId = Int32.Parse(HttpContext.User.Identity.Name),
                StatusIsporuke = StatusIsporuke.Obrada,
                Stavke = stavke,
                VrstaNarudzbine = model.VrstaNarudzbine
            };
            jedinicaRada.NarudzbinaRepozitorijum.Dodaj(narudzbina);
            jedinicaRada.Sacuvaj();

            return View("Index");
        }
    }
}
