using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class CvetViewModel
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public string Opis { get; set; }
        public Familija Familija { get; set; }
        public string Slika { get; set; }
        public Boja Boja { get; set; }
    }
}
