using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    [Authorize]
    public class NarudzbinaController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly UserManager<Osoba> manager;

        public NarudzbinaController(IJedinicaRada jedinicaRada, UserManager<Osoba> manager)
        {
            this.jedinicaRada = jedinicaRada;
            this.manager = manager;
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
        [Authorize(Roles = "Kupac")]
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

                if (proizvod.GetType() == typeof(Cvet))
                {
                    proizvodView.JesteCvet = true;
                    proizvodiView.Add(proizvodView);
                }
                else
                {
                    CvetniAranzman cvAr = jedinicaRada.CvetniAranzmanRepozitorijum.PretragaId(proizvod.ProizvodId);
                    if(cvAr.KupacId == Int32.Parse(HttpContext.User.Claims.ElementAt(0).Value))
                    {
                        proizvodiView.Add(proizvodView);
                    }
                }
            }
            kreirajNarudzbinu.Proizvodi = proizvodiView;
            kreirajNarudzbinu.ProdajnaMesta = prodajnaMesta.Select(p => new SelectListItem(p.Adresa, p.ProdajnoMestoId.ToString())).ToList();
            return View("Create", kreirajNarudzbinu);
        }
        [Authorize(Roles = "Kupac")]
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
                KupacId = Int32.Parse(HttpContext.User.Claims.ElementAt(0).Value),
                StatusIsporuke = StatusIsporuke.Obrada,
                Stavke = stavke,
                VrstaNarudzbine = model.VrstaNarudzbine
            };
            jedinicaRada.KupacRepozitorijum.PretragaId(narudzbina.KupacId).BrojNarudzbina++;
            jedinicaRada.NarudzbinaRepozitorijum.Dodaj(narudzbina);
            jedinicaRada.Sacuvaj();
            return RedirectToAction("Index", "Narudzbina");
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult Edit(NarudzbinaViewModel model)
        {
            if(string.IsNullOrEmpty(model.Kupac) || string.IsNullOrWhiteSpace(model.Kupac))
            {
                return RedirectToAction("AdministratorProfil", "Pocetna");
            }
            var postojiKupac = jedinicaRada.KupacRepozitorijum.Pretraga(k => k.UserName.ToLower().Trim() == model.Kupac.ToLower().Trim());
            if(postojiKupac.Count  == 0)
            {
                return View(null);
            }

            var narudzbine = jedinicaRada.NarudzbinaRepozitorijum.PretragaKupac(n => n.Kupac.UserName.ToLower().Trim() == model.Kupac.ToLower().Trim());
            List<NarudzbinaViewModel> narudzbineVM = new List<NarudzbinaViewModel>();
            foreach(Narudzbina narudzbina in narudzbine)
            {
                NarudzbinaViewModel narudzbinaVM = new NarudzbinaViewModel()
                {
                    VrstaNarudzbine = narudzbina.VrstaNarudzbine,
                    Adresa = narudzbina.Adresa,
                    Kupac = narudzbina.Kupac.UserName,
                    NarudzbinaId = narudzbina.NarudzbinaId,
                    ProdajnoMesto = narudzbina.ProdajnoMesto?.Adresa,
                    StatusIsporuke = narudzbina.StatusIsporuke,
                };
                foreach (Stavka s in narudzbina.Stavke)
                {
                    string stavka = jedinicaRada.ProizvodRepozitorijum.PretragaId(s.ProizvodId).Naziv;
                    narudzbinaVM.Stavke.Add(stavka);
                }
                narudzbineVM.Add(narudzbinaVM);
            }
            return View(narudzbineVM);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public string IzmeniStatus(int id, int StatusIsporuke)
        {
            Narudzbina narudzbina = jedinicaRada.NarudzbinaRepozitorijum.PretragaId(id);
            narudzbina.StatusIsporuke = (Domen.StatusIsporuke) StatusIsporuke;
            jedinicaRada.Sacuvaj();
            return narudzbina.StatusIsporuke.ToString();
        }
        public IActionResult Index()
        {
            List<Narudzbina> narudzbine = jedinicaRada.NarudzbinaRepozitorijum.Pretraga(n => n.KupacId == Int32.Parse(HttpContext.User.Claims.ElementAt(0).Value));
            List<NarudzbinaViewModel> narudzbineVM = new List<NarudzbinaViewModel>();
            foreach(Narudzbina narudzbina in narudzbine)
            {
                NarudzbinaViewModel nvm = new NarudzbinaViewModel()
                {
                    Adresa = narudzbina.Adresa,
                    ProdajnoMesto = narudzbina.ProdajnoMesto?.Adresa,
                    StatusIsporuke = narudzbina.StatusIsporuke,
                    VrstaNarudzbine = narudzbina.VrstaNarudzbine,
                };
                foreach(Stavka s in narudzbina.Stavke)
                {
                    string stavka = jedinicaRada.ProizvodRepozitorijum.PretragaId(s.ProizvodId).Naziv + "   [Količina: " + s.Kolicina + "]";
                    nvm.Stavke.Add(stavka);
                };
                narudzbineVM.Add(nvm);
            }
            return View(narudzbineVM);
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult PretragaNarudzbina()
        {
            return PartialView();
        }
        [Authorize(Roles = "Administrator")]
        [HttpDelete]
        public void Izbrisi(int id)
        {
            jedinicaRada.NarudzbinaRepozitorijum.BrisiId(id);
            jedinicaRada.Sacuvaj();
        }
    }
}
