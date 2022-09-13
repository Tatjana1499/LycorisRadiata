using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    [Authorize]
    public class PakovanjeController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly IWebHostEnvironment webHost;

        public PakovanjeController(IJedinicaRada jedinicaRada, IWebHostEnvironment webHost)
        {
            this.jedinicaRada = jedinicaRada;
            this.webHost = webHost;
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
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create(PakovanjeViewModel model)
        {

            string wwwRootPath = webHost.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.SlikaFile.FileName);
            string extension = Path.GetExtension(model.SlikaFile.FileName);
            model.Slika = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/slike/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                model.SlikaFile.CopyTo(fileStream);
            }

            Pakovanje pakovanje = new Pakovanje()
            {
                Boja = model.Boja,
                Materijal = model.Materijal,
                Naziv = model.Naziv,
                Cena = model.Cena,
                Oblik = model.Oblik,
                Slika = model.Slika
            };
            jedinicaRada.PakovanjeRepozitorijum.Dodaj(pakovanje);
            jedinicaRada.Sacuvaj();
            return View();
        }
    }
}
