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
        [Phone]
        public string BrojTelefona { get; set; }
        [Required(ErrorMessage = "*")]
        [MinLength(7)]
        public string Lozinka { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
