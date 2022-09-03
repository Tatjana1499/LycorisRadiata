using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class IzmeniKupcaViewModel
    {
        public int KupacId { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(7)]
        public string Lozinka { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
    }
}
