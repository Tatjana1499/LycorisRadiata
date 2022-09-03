using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface IKupacRepozitorijum  : IRepozitorijum<Kupac>
    {
        public Kupac PretragaKorisnickoImeLozinka(string korisnickoIme, string lozinka);
        public Kupac PretragaId(int id);
    }
}
