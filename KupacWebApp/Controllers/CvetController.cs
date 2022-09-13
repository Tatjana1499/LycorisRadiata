using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class CvetController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly IWebHostEnvironment webHost;

        public CvetController(IJedinicaRada jedinicaRada, IWebHostEnvironment webHost)
        {
            this.jedinicaRada = jedinicaRada;
            this.webHost = webHost;
        }
        [Authorize(Roles = "Kupac")]
        public IActionResult Index(int id)
        {
            Cvet cvet = jedinicaRada.CvetRepozitorijum.PretragaId(id);
            CvetViewModel cvetView = new CvetViewModel()
            {
                Boja = cvet.Boja,
                Cena = cvet.Cena,
                Familija = cvet.Familija,
                Naziv = cvet.Naziv,
                Opis = cvet.Opis,
                Slika = cvet.Slika
            };
            return PartialView(cvetView);
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public IActionResult Create(CvetViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Create();
            }

            string wwwRootPath = webHost.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.SlikaFile.FileName);
            string extension = Path.GetExtension(model.SlikaFile.FileName);
            model.Slika = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/slike/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                model.SlikaFile.CopyTo(fileStream);
            }

            Cvet cvet = new Cvet()
            {
                Boja = model.Boja,
                Opis = model.Opis,
                Naziv = model.Naziv,
                Cena = model.Cena,
                Familija = model.Familija,
                Slika = model.Slika
            };
            jedinicaRada.CvetRepozitorijum.Dodaj(cvet);
            jedinicaRada.Sacuvaj();
            return RedirectToAction("AdministratorProfil", "Pocetna");
        }
    }
}