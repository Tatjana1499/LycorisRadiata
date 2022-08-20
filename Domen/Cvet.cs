using System;

namespace Domen
{
    public enum Familija
    {
        Aktinidijevke,
        Breze,
        Jagorcevine,
        Ruze,
        Usnatice
    }
    public enum Boja 
    {
        Crvena,
        Bela,
        Zuta,
        Plava,
        Ljubicasta
    }
    public class Cvet : Proizvod
    {
        public string Opis { get; set; }
        public Familija Familija { get; set; }
        public string Slika { get; set; }
        public Boja Boja { get; set; }

        public override string ToString()
        {
            return $"{Naziv} {Boja} {Cena}";
        }

    }
    
}