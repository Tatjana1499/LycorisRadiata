using Domen;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    public class ProdajnoMestoController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;

        public ProdajnoMestoController(IJedinicaRada jedinicaRada)
        {
            this.jedinicaRada = jedinicaRada;
        }
        public IActionResult Index()
        {
            List<ProdajnoMesto> prodajnaMesta =  jedinicaRada.ProdajnoMestoRepozitorijum.VratiSve();
            return View(prodajnaMesta);
        }
    }
}
