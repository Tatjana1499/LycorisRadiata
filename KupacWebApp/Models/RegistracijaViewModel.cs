using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class RegistracijaViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "*")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "*")]
        public string KorisnickoIme { get; set; }
        [Required(ErrorMessage = "*")]
        [Phone(ErrorMessage = "Samo brojevi")]
        public string BrojTelefona { get; set; }
        [Required(ErrorMessage = "*")]
        [MinLength(7, ErrorMessage = "Minimum 7 karaktera")]
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "*")]
        [Compare("Lozinka",ErrorMessage = "Greška")]
        public string LozinkaProvera { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress(ErrorMessage = "*")]
        public string Email { get; set; }

    }
}
