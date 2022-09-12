using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Kupac : Osoba
    {
        public DateTime DatumKreiranjaNaloga { get; set; }
        public int BrojNarudzbina { get; set; }
        // public string BrojTelefona { get; set; }
        // public string Email { get; set; }  
    }
}
