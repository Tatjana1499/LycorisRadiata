using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class ProizvodViewModel
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public bool JesteCvet { get; set; } = false;
    }
}
