using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Materijal
    {
        Plastika,
        Drvo,
        Karton,
        Keramika
    }
    public enum Oblik
    {
        Srce,
        Krug,
        Kvadrat
    }
    public class Pakovanje
    {
        public int PakovanjeId { get; set; }
        public string Naziv { get; set; }
        public Materijal Materijal { get; set; }
        public Oblik Oblik { get; set; }
        public Boja Boja { get; set; }
        public decimal Cena { get; set; }
        public string Slika { get; set; }
        public override string ToString()
        {
            return $"{Naziv}         {{Boja: {Boja}}}";
        }
    }
}
