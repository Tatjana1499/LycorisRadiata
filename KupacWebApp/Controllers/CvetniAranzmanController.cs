using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SlojPristupaPodacima.JedinicaRada;
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

        public IActionResult Create()
        {
            KreirajCvetniAranzmanViewModel model = new KreirajCvetniAranzmanViewModel();
            var pakovanja = jedinicaRada.PakovanjeRepozitorijum.VratiSve();
            model.Pakovanja = pakovanja.Select(p => new SelectListItem(p.ToString(), p.PakovanjeId.ToString())).ToList();
            model.Cvece = jedinicaRada.CvetRepozitorijum.VratiSve();
            model.Dekoracije = new List<DekoracijaViewModel>();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(KreirajCvetniAranzmanViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }
            jedinicaRada.CvetniAranzmanRepozitorijum.Dodaj(new CvetniAranzman() { 
                Masna = model.Masna,
                Namena = model.Namena,
                Napomena = model.Napomena,
                Naziv = "CvAr1",
                PakovanjeId = model.PakovanjeId,
                Sjaj = model.Sjaj,
                Cena = 0
            });
            //jedinicaRada.Sacuvaj();
            //List<Dekoracija> dekoracije = new List<Dekoracija>()
            //{
            //    new Dekoracija()
            //    {
            //        BrojCvetova = 2,
            //        CvetProizvodId = 4,
            //        CvetniAranzmanProizvodId = model.ProizvodId,
            //    },
            //    new Dekoracija()
            //    {
            //        BrojCvetova = 1,
            //        CvetProizvodId = 7,
            //        CvetniAranzmanProizvodId = model.ProizvodId,
            //    },
            //    new Dekoracija()
            //    {
            //        BrojCvetova = 4,
            //        CvetProizvodId = 8,
            //        CvetniAranzmanProizvodId = model.ProizvodId,
            //    },

            //};
            List<Dekoracija> dekoracije = new List<Dekoracija>();
            foreach (DekoracijaViewModel dvm in model.Dekoracije)
            {
                dekoracije.Add(new Dekoracija()
                {
                    CvetProizvodId = dvm.CvetProizvodId,
                    CvetniAranzmanProizvodId = dvm.CvetniAranzmanProizvodId,
                    BrojCvetova = dvm.BrojCvetova
                });
            }
            foreach (Dekoracija d in dekoracije)
            {
                jedinicaRada.DekoracijaRepozitorijum.Dodaj(d);
            }
            jedinicaRada.Sacuvaj();
            return RedirectToAction("Index", "Pocetna");
        }
    }
}
