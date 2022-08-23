using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Kupac
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string KorisnickoIme { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
