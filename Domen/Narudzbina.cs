using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum VrstaNarudzbine
    {
        Preuzimanje,
        Dostava
    }
    public enum StatusIsporuke
    {
        Obrada,
        Dostavljeno
    }
    public class Narudzbina
    {
        public int NarudzbinaId { get; set; }
        public VrstaNarudzbine VrstaNarudzbine { get; set; }
        public string Adresa { get; set; }
        public StatusIsporuke StatusIsporuke { get; set; }

    }
}
