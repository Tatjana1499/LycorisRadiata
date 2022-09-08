using Domen;
using KupacWebApp.Models;
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
    public class CvetController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly IWebHostEnvironment webHost;

        public CvetController(IJedinicaRada jedinicaRada, IWebHostEnvironment webHost)
        {
            this.jedinicaRada = jedinicaRada;
            this.webHost = webHost;
        }
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
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(CvetViewModel model)
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

            Cvet cvet = new Cvet()
            {
                Boja = model.Boja,
                Opis = model.Opis,
                Naziv = model.Naziv,
                Cena = model.Cena,
                Familija = model.Familija,
                //////////////////!!!!!!!!!!!!!!!!!!!!!!
                Slika = model.Slika
            };
            jedinicaRada.CvetRepozitorijum.Dodaj(cvet);
            jedinicaRada.Sacuvaj();
            return View();
        }

        //private string UploadFile(CvetViewModel model)
        //{
        //    string fileName = null;
        //    if(model.Slika != null)
        //    {
        //        string uploadDir = Path.Combine(webHost.WebRootPath, "slike");
        //        fileName = Guid.NewGuid().ToString() + "-" + model.Slika.FileName;
        //        string filePath = Path.Combine(uploadDir, fileName);
        //        using(var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            model.Slika.CopyTo(fileStream);
        //        }
        //    }
        //    return fileName;
        //}


        /*string wwwRootPath = host Environment . WebRoot Path ;
string fileName = Path.GetFileNameWithout Extension ( imageModel . ImageFile.FileName ) ;
string extension = Path.GetExtension ( imageModel . ImageFile.FileName ) ;
imageModel . ImageName = fileName = fileName + DateTime.Now.ToString ( " yymmssfff " ) + extension ;
string path Path.Combine ( wwwRootPath + " / Image " , fileName ) ;
using ( var fileStream = new FileStream ( path , FileMode.Create ) )
(
    await imageModel . ImageFile.CopyToAsync ( fileStream ) ;
            .*/










    }
}