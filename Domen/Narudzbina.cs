using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum VrstaNarudzbine
    {
        Preuzimanje = 0,
        Dostava = 1
    }
    public enum StatusIsporuke
    {
        Obrada = 0,
        Dostavljeno = 1,
        Zastarelo = 2
    }
    public class Narudzbina
    {
        public int NarudzbinaId { get; set; }
        public VrstaNarudzbine VrstaNarudzbine { get; set; }
        public string Adresa { get; set; }
        public StatusIsporuke StatusIsporuke { get; set; }
        public ProdajnoMesto ProdajnoMesto { get; set; }
        public int? ProdajnoMestoId { get; set; }
        public Kupac Kupac { get; set; }
        public int KupacId { get; set; }
        public List<Stavka> Stavke { get; set; }

        public override string ToString()
        {
            return $"{VrstaNarudzbine.ToString()} + {Adresa}";
        }
    }
}
