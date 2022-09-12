using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class NarudzbinaViewModel
    {
        public int NarudzbinaId { get; set; }
        public VrstaNarudzbine VrstaNarudzbine { get; set; }
        public string Adresa { get; set; }
        public StatusIsporuke StatusIsporuke { get; set; }
        public string ProdajnoMesto { get; set; }
        public string Kupac { get; set; }
        public List<string> Stavke { get; set; } = new List<string>();



    }
}
