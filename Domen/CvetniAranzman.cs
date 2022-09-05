using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Sjaj 
    {
        Srebrni,
        Beli,
        Sivi,
        Nema
    }
    public enum Namena
    { 
        Rodjendan,
        DanZena,
        Svadba,
        Poslovno,
        Ostalo
    }

    public class CvetniAranzman : Proizvod
    {
        public Sjaj Sjaj { get; set; }
        public Boolean Masna { get; set; }
        public Namena Namena { get; set; }
        public string Napomena { get; set; }
        public Pakovanje Pakovanje { get; set; }
        public int PakovanjeId { get; set; }
        public Kupac Kupac { get; set; }
        public int KupacId { get; set; }
        public override string ToString()
        {
            return $"{Naziv} {Cena}";
        }
    }
}
