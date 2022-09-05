using Domen;
using KupacWebApp.Models;
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
    }
}