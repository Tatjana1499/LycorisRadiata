using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class StavkaViewModel
    {
       // public int NarudzbinaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; } = 1;
        public string Naziv { get; set; }
        public int RedniBroj { get; set; }
    }
}
