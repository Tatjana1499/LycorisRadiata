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
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using Microsoft.AspNetCore.Authorization;

namespace KupacWebApp.Controllers
{
    public class AutentifikacijaController : Controller
    {
        private readonly IJedinicaRada jedinicaRada;
        private readonly UserManager<Osoba> manager;
        private readonly SignInManager<Osoba> signIn;

        public object SingInResult { get; private set; }

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
            SignInResult rezultat = new SignInResult();
            try
            {
                rezultat = await signIn.PasswordSignInAsync(prijava.KorisnickoIme, prijava.Lozinka, false, false);
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Desila se greška.");
                return View();
            }
            
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
            IdentityResult rezultat = new IdentityResult();
            try
            {
                rezultat = await manager.CreateAsync(kupac, registacija.Lozinka);
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Desila se greška.");
                return View();
            }
            
           
            if (rezultat.Errors.Any(e => e.Code.Contains("UserName")))
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime već postoji");
                return View();
            }
            if (!rezultat.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Lozinka mora da sadrži makar jedno veliko i jedno malo slovo, broj i karakter koji nije alfanumerički");
                return View();
            }
            try
            {
                await manager.AddToRoleAsync(kupac, "Kupac");
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Desila se greška.");
                return View();
            }
           
            return RedirectToAction("Prijava", "Autentifikacija");
        }
        [Authorize]
        public async Task<IActionResult> Odjava()
        {
            await signIn.SignOutAsync();
            return RedirectToAction("Index", "Pocetna");
        }
        [Authorize]
        public async Task<IActionResult> Greska()
        {
            await signIn.SignOutAsync();
            return PartialView();
        }
        [HttpGet]
        [Authorize(Roles ="Kupac")]
        public IActionResult Edit()
        {
            Osoba currentUser = new Osoba();
            try
            {
                var userId = manager.GetUserId(HttpContext.User);
                currentUser = manager.FindByIdAsync(userId).Result;
            }
            catch
            {
                return RedirectToAction("Greska", "Autentifikacija");
            }

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
        [Authorize(Roles = "Kupac")]
        public async Task<IActionResult> Edit(IzmeniKupcaViewModel model)
        {

            if ((model.StaraLozinka is null && model.NovaLozinka is not null) || (model.StaraLozinka is not null && model.NovaLozinka is null))
            {
                ModelState.AddModelError(string.Empty, "Greska pri popunjavanju lozinki");
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
            Osoba currentUser = new Osoba();
            try
            {
                var userId = manager.GetUserId(HttpContext.User);
                currentUser = manager.FindByIdAsync(userId).Result;
            }
            catch
            {
                return RedirectToAction("Greska", "Autentifikacija");
            }
            

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
            IdentityResult rezultat = new IdentityResult();
            try
            {
                rezultat = await manager.UpdateAsync(currentUser);
            }
            catch
            {
                return RedirectToAction("Greska", "Autentifikacija");
            }
            
            if (!rezultat.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Korisničko ime već postoji");
                return View();
            }

            
            
            return RedirectToAction("KupacProfil", "Pocetna");
        }
    }
}