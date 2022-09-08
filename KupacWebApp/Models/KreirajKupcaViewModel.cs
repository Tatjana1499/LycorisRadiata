using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class KreirajKupcaViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "*")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "*")]
        public string KorisnickoIme { get; set; }
        [Required(ErrorMessage = "*")]
        [Phone(ErrorMessage = "Unesi samo brojeve.")]
        public string BrojTelefona { get; set; }
        [Required(ErrorMessage = "*")]
        [MinLength(7, ErrorMessage = "Minimum 7 karaktera.")]
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress(ErrorMessage = "Neispravan email format.")]
        public string Email { get; set; }

    }
}
