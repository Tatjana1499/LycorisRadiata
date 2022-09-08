using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class IzmeniKupcaViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "*")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "*")]
        [Phone(ErrorMessage = "Unesi samo brojeve.")]
        public string BrojTelefona { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string Email { get; set; }
        [MinLength(7,ErrorMessage = "Minimum 7 karaktera.")]
        public string StaraLozinka { get; set; }
        [MinLength(7, ErrorMessage = "Minimum 7 karaktera.")]
        public string NovaLozinka { get; set; }
        [Required(ErrorMessage = "*")]
        public string KorisnickoIme { get; set; }
    }
}
