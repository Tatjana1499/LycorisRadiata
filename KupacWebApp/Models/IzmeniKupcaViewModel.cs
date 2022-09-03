using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class IzmeniKupcaViewModel
    {
        [Required(ErrorMessage = "Obavezno polje.")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public string BrojTelefona { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(7,ErrorMessage = "Minimum 7 karaktera")]
        public string StaraLozinka { get; set; }
        [MinLength(7, ErrorMessage = "Minimum 7 karaktera")]
        public string NovaLozinka { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public string KorisnickoIme { get; set; }
    }
}
