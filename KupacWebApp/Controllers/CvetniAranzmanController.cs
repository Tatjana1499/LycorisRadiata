using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KupacWebApp.Controllers
{
    [Authorize(Roles = "Kupac")]
    public class CvetniAranzmanController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public CvetniAranzmanController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        public IActionResult Index()
        {
            List<CvetniAranzman> cvetniAranzmani = jedinicaRada.CvetniAranzmanRepozitorijum.Pretraga(c => c.KupacId == Int32.Parse(HttpContext.User.Claims.ElementAt(0).Value));

            List<CvetniAranzmanViewModel> cvViews = new List<CvetniAranzmanViewModel>();
            foreach(CvetniAranzman cv in cvetniAranzmani)
            {
                CvetniAranzmanViewModel cvView = new CvetniAranzmanViewModel()
                {
                    Masna = cv.Masna,
                    Namena = cv.Namena,
                    Napomena = cv.Napomena,
                    Pakovanje = cv.Pakovanje,
                    Sjaj = cv.Sjaj,
                    Naziv = cv.Naziv
                };

                List<Cvet> cvetovi = new List<Cvet>();
                foreach(Dekoracija dekoracija in cv.Dekoracije)
                {
                    Cvet cvet = (jedinicaRada.DekoracijaRepozitorijum.Pretraga(d => d.CvetProizvodId == dekoracija.CvetProizvodId && dekoracija.CvetniAranzmanProizvodId == d.CvetniAranzmanProizvodId)).First().Cvet;
                    cvView.Cvece.Add(cvet.ToString() + $"Količina: {dekoracija.BrojCvetova} ]");
                }

                cvViews.Add(cvView);
            }
            return View(cvViews);
        }
        public IActionResult Create()
        {
            KreirajCvetniAranzmanViewModel model = new KreirajCvetniAranzmanViewModel();
            var pakovanja = jedinicaRada.PakovanjeRepozitorijum.VratiSve();
            model.Pakovanja = pakovanja.Select(p => new SelectListItem(p.ToString(), p.PakovanjeId.ToString())).ToList();
            List<Cvet> cvece = jedinicaRada.CvetRepozitorijum.VratiSve();
            foreach(Cvet c in cvece)
            {
                CvetViewModel cvm = new CvetViewModel()
                {
                    Boja = c.Boja,
                    Cena = c.Cena,
                    Familija = c.Familija,
                    Naziv = c.Naziv,
                    Opis = c.Opis,
                    Slika = c.Slika,
                    ProizvodId = c.ProizvodId
                };
                model.Cvece.Add(cvm);
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(KreirajCvetniAranzmanViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return Create();
            }
            List<Dekoracija> dekorcije = new List<Dekoracija>();
            foreach (DekoracijaViewModel dekVM in model.Dekoracije)
            {
                if(dekVM.BrojCvetova > 0)
                {
                    Dekoracija dekoracija = new Dekoracija()
                    {
                        BrojCvetova = dekVM.BrojCvetova,
                        CvetProizvodId = dekVM.CvetProizvodId
                    };
                    dekorcije.Add(dekoracija);
                }
            }
            if (dekorcije.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "Prazan cvetni aranzman.");
                return Create();
            }
            decimal ukupnaCena = 0;
            foreach (DekoracijaViewModel dvm in model.Dekoracije)
            {
                Cvet cvet = jedinicaRada.CvetRepozitorijum.PretragaId(dvm.CvetProizvodId);
                ukupnaCena += cvet.Cena * dvm.BrojCvetova;
            }
            ukupnaCena += jedinicaRada.PakovanjeRepozitorijum.PretragaId(model.PakovanjeId).Cena;

            CvetniAranzman cvAr = new CvetniAranzman()
            {
                Masna = model.Masna,
                Namena = model.Namena,
                Napomena = model.Napomena,
                Naziv = model.Naziv,
                PakovanjeId = model.PakovanjeId,
                Sjaj = model.Sjaj,
                Cena = ukupnaCena,
                Dekoracije = dekorcije,
                KupacId = Int32.Parse(HttpContext.User.Claims.ElementAt(0).Value)
        };
            
            jedinicaRada.CvetniAranzmanRepozitorijum.Dodaj(cvAr);
            jedinicaRada.Sacuvaj();
            return RedirectToAction("Index");
        }
        public IActionResult dodajCvet(int cvetId, string Naziv, string Boja, int RedniBroj)
        {
            DekoracijaViewModel model = new DekoracijaViewModel()
            {
                CvetProizvodId = cvetId,
                Naziv = Naziv,
                Boja = Boja,
                RedniBroj = RedniBroj
            };

            return PartialView(model);
        }
        public IActionResult ModalCvetniAranzman(int id)
        {
            CvetniAranzman cvetniAranzman = jedinicaRada.CvetniAranzmanRepozitorijum.PretragaId(id);
            CvetniAranzmanViewModel model = new CvetniAranzmanViewModel()
            {
                Masna = cvetniAranzman.Masna,
                Namena = cvetniAranzman.Namena,
                Napomena = cvetniAranzman.Napomena,
                Naziv = cvetniAranzman.Naziv,
                Pakovanje = cvetniAranzman.Pakovanje,
                Sjaj = cvetniAranzman.Sjaj,
            };

            List<Cvet> cvetovi = new List<Cvet>();
            foreach(Dekoracija dekoracija in cvetniAranzman.Dekoracije)
            {
                Cvet cvet = (jedinicaRada.DekoracijaRepozitorijum.Pretraga(d => d.CvetProizvodId == dekoracija.CvetProizvodId && dekoracija.CvetniAranzmanProizvodId == d.CvetniAranzmanProizvodId)).First().Cvet;
                model.Cvece.Add(cvet.ToString() + $"Količina: {dekoracija.BrojCvetova} ]");
            }
            return PartialView(model);
        }
    }
}
