﻿using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Controllers
{
    [Authorize]
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
            List<ProdajnoMestoViewModel> prodMestaVM = new List<ProdajnoMestoViewModel>();
            foreach(ProdajnoMesto prm in prodajnaMesta)
            {
                ProdajnoMestoViewModel prmVM = new ProdajnoMestoViewModel()
                {
                    Adresa = prm.Adresa,
                    RadnoVreme = prm.RadnoVreme,
                    Sajt = prm.Sajt
                };
                prodMestaVM.Add(prmVM);
            }
            return PartialView(prodMestaVM);
        }
    }
}
