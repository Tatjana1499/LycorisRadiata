using Domen;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    public class CvetController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public CvetController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        public IActionResult Index()
        {
            List<Cvet> cvece = jedinicaRada.CvetRepozitorijum.VratiSve();
            return View(cvece);
        }
        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return RedirectToAction("Index", "Narudzbina");
        //}
    }
}
