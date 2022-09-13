using Domen;
using KupacWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using SlojPristupaPodacima.JedinicaRada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace KupacWebApp.Controllers
{
    public class AutentifikacijaController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly UserManager<Osoba> manager;
        private readonly SignInManager<Osoba> signIn;

        public AutentifikacijaController(IJedinicaRada jedinicaRada, UserManager<Osoba> manager, SignInManager<Osoba> signIn)
        {
            this.jedinicaRada = jedinicaRada;
            this.manager = manager;
            this.signIn = signIn;
        }
        [HttpGet]
        public IActionResult Prijava()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Prijava(PrijavaViewModel prijava)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var rezultat = await signIn.PasswordSignInAsync(prijava.KorisnickoIme, prijava.Lozinka, false, false);
            
            if (rezultat.Succeeded)
            {
                return RedirectToAction("Index", "Pocetna");
            }

            ModelState.AddModelError(string.Empty, "Korisnik ne postoji.");

            return View();
        }
        [HttpGet]
        public IActionResult Registracija()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registracija(RegistracijaViewModel registacija)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(registacija.KorisnickoIme.Contains(" "))
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime ne može da sadrži razmak");
                return View();
            }

            Kupac kupac = new Kupac()
            {
                Ime = registacija.Ime,
                Prezime = registacija.Prezime,
                Email = registacija.Email,
                UserName = registacija.KorisnickoIme,
                PhoneNumber = registacija.BrojTelefona,
                BrojNarudzbina = 0,
                DatumKreiranjaNaloga = DateTime.Now
            };
            
            var rezultat = await manager.CreateAsync(kupac, registacija.Lozinka);
           
            if (rezultat.Errors.Any(e => e.Code.Contains("UserName")))
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime već postoji");
                return View();
            }
            if (!rezultat.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Lozinka mora da sadrži makar jedno veliko i jedno malo slovo, broj i karakter koji nije alfanumerički.");
                return View();
            }
            await manager.AddToRoleAsync(kupac, "Kupac");
            return RedirectToAction("Prijava", "Autentifikacija");
        }
        public async Task<IActionResult> Odjava(PrijavaViewModel prijava)
        {
            await signIn.SignOutAsync();
            return RedirectToAction("Index", "Pocetna");
        }
        [HttpGet]
        public IActionResult Edit()
        {

            var userId = manager.GetUserId(HttpContext.User);
            Osoba currentUser = manager.FindByIdAsync(userId).Result;

            IzmeniKupcaViewModel model = new IzmeniKupcaViewModel()
            {
                Ime = currentUser.Ime,
                Prezime = currentUser.Prezime,
                BrojTelefona = currentUser.PhoneNumber,
                Email = currentUser.Email,
                KorisnickoIme = currentUser.UserName
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(IzmeniKupcaViewModel model)
        {

            if ((model.StaraLozinka is null && model.NovaLozinka is not null) || (model.StaraLozinka is not null && model.NovaLozinka is null))
            {
                ModelState.AddModelError(string.Empty, "Greska pri popunjavanju lozinki.");
                return Edit();
            }
            if (model.KorisnickoIme.Contains(" "))
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime ne može da sadrži razmak");
                return View();
            }
            if (!ModelState.IsValid)
            {
                return Edit();
            }

            var userId = manager.GetUserId(HttpContext.User);
            Osoba currentUser = manager.FindByIdAsync(userId).Result;

            currentUser.Email = model.Email;
            currentUser.Ime = model.Ime;
            currentUser.Prezime = model.Prezime;
            currentUser.PhoneNumber = model.BrojTelefona;
            currentUser.UserName = model.KorisnickoIme;

            if (model.StaraLozinka is not null)
            {
                var tacnaStara = await manager.CheckPasswordAsync(currentUser, model.StaraLozinka);
                if (!tacnaStara && model.NovaLozinka is not null)
                {
                    ModelState.AddModelError(string.Empty, "Neispravna stara lozinka.");
                    return Edit();
                }
            }

            if(!(model.StaraLozinka is null && model.NovaLozinka is null))
            {
                var proslaSifra = await manager.ChangePasswordAsync(currentUser, model.StaraLozinka, model.NovaLozinka);
                if (!proslaSifra.Succeeded)
                {
                    ModelState.AddModelError(string.Empty, "Lozinka mora da sadrži makar jedno veliko i jedno malo slovo, broj i karakter koji nije alfanumerički.");
                    return View();
                }
            }
            var rezultat = await manager.UpdateAsync(currentUser);
            
            if (!rezultat.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime već postoji");
                return View();
            }

            
            
            return RedirectToAction("KupacProfil", "Pocetna");
        }
    }
}