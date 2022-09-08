using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KupacWebApp.Controllers
{
    public class CvetniAranzmanController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public CvetniAranzmanController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        public IActionResult Index()
        {
            var cvetniAranzmani = jedinicaRada.CvetniAranzmanRepozitorijum.Pretraga(c => c.KupacId == Int32.Parse(HttpContext.User.Identity.Name));

            List<CvetniAranzmanViewModel> cvViews = new List<CvetniAranzmanViewModel>();
            foreach(CvetniAranzman cv in cvetniAranzmani)
            {
                CvetniAranzmanViewModel cvView = new CvetniAranzmanViewModel()
                {
                    Masna = cv.Masna,
                    Namena = cv.Namena,
                    Napomena = cv.Napomena,
                    Pakovanje = cv.Pakovanje,
                    Sjaj = cv.Sjaj
                };
                cvViews.Add(cvView);
            }
            
            for (int i = 0; i < cvetniAranzmani.Count; i++)
            {
                var proizvod = jedinicaRada.ProizvodRepozitorijum.PretragaId(cvetniAranzmani[i].ProizvodId);
                cvViews[i].Naziv = proizvod.Naziv;
                var dekoracije = jedinicaRada.DekoracijaRepozitorijum.Pretraga(d => d.CvetniAranzmanProizvodId == cvetniAranzmani[i].ProizvodId);
                
                for (int j = 0; j < dekoracije.Count; j++)
                {
                    cvViews[i].Cvece.Add(dekoracije[j].Cvet.ToString() + $"Količina: {dekoracije[j].BrojCvetova}]");
                }
               
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
                KupacId = Int32.Parse(HttpContext.User.Identity.Name)
            };
            jedinicaRada.CvetniAranzmanRepozitorijum.Dodaj(cvAr);
            jedinicaRada.Sacuvaj();
            foreach (Dekoracija d in dekorcije)
            {
                d.CvetniAranzmanProizvodId = cvAr.ProizvodId;
                jedinicaRada.DekoracijaRepozitorijum.Dodaj(d);
            }
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
    }
}
