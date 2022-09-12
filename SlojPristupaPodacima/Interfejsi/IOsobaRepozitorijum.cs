using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface IOsobaRepozitorijum : IRepozitorijum<Osoba>
    {
        public Osoba PretragaKorisnickoImeLozinka(string korisnickoIme, string lozinka);
    }
}
