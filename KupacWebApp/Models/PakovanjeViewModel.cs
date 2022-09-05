using Domen;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class PakovanjeViewModel
    {
        public string Naziv { get; set; }
        public Materijal Materijal { get; set; }
        public Oblik Oblik { get; set; }
        public Boja Boja { get; set; }
        public decimal Cena { get; set; }
        public string Slika { get; set; }

    }
}
