using Domen;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class KreirajCvetViewModel
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public decimal Cena { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        public Familija Familija { get; set; }
        [Required]
        public string Slika { get; set; }
        public IFormFile SlikaFile { get; set; }
        [Required]
        public Boja Boja { get; set; }
    }
}
