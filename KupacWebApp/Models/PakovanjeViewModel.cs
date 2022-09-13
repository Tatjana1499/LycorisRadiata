using Domen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class PakovanjeViewModel
    {
        [Required(ErrorMessage ="*")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "*")]
        public Materijal Materijal { get; set; }
        [Required(ErrorMessage = "*")]
        public Oblik Oblik { get; set; }
        [Required(ErrorMessage = "*")]
        public Boja Boja { get; set; }
        [Required(ErrorMessage = "*")]
        public decimal Cena { get; set; }
        public string Slika { get; set; }
        [Required(ErrorMessage = "*")]
        public IFormFile SlikaFile { get; set; }

    }
}
