using Domen;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class CvetViewModel
    {
        [Required(ErrorMessage = "*")]
        public int ProizvodId { get; set; }
        [Required(ErrorMessage = "*")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "*")]
        public decimal Cena { get; set; }
        [Required(ErrorMessage = "*")]
        public string Opis { get; set; }
        [Required(ErrorMessage = "*")]
        public Familija Familija { get; set; }
        public string Slika { get; set; }
        [Required(ErrorMessage = "*")]
        public IFormFile SlikaFile { get; set; }
        [Required(ErrorMessage = "*")]
        public Boja Boja { get; set; }
    }
}
