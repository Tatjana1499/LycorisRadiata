using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Domen;
using System.Security.Claims;

namespace KupacWebApp.Controllers
{
    public class PocetnaController : Controller
    {
        public IActionResult Index()
        {

            var user = HttpContext.User;
            
            if (user is null)
            {
                return RedirectToAction("Index", "Prijava");
            }

            return View();
        }
    }
}
