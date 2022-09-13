using System;

namespace Domen
{
    public enum Familija
    {
        Aktinidijevke = 0,
        Breze = 1,
        Jagorcevine = 2,
        Ruze = 3,
        Usnatice = 3
    }
    public enum Boja 
    {
        Crvena = 0,
        Bela = 1,
        Zuta = 2,
        Plava = 3,
        Ljubicasta = 4
    }
    public class Cvet : Proizvod
    {
        public string Opis { get; set; }
        public Familija Familija { get; set; }
        public string Slika { get; set; }
        public Boja Boja { get; set; }

        public override string ToString()
        {
            return $"{Naziv}    [ Boja: {Boja},   ";
        }

    }
    
}