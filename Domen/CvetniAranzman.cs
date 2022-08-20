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
        Sivi
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
        public override string ToString()
        {
            return $"{Naziv} {Cena}";
        }
    }
}
