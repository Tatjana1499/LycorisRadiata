 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Stavka
    {
        public int StavkaId { get; set; }
        public Narudzbina Narudzbina { get; set; }
        public int NarudzbinaId { get; set; }
        public Proizvod Proizvod { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
    }
}
