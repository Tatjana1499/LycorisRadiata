using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class OsobaRepozitorijum : IOsobaRepozitorijum
    {
        private readonly CvecaraContext context;

        public OsobaRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Osoba entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(Osoba entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Osoba entitet)
        {
            throw new NotImplementedException();
        }

        public List<Osoba> Pretraga(Expression<Func<Osoba, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<Osoba> VratiSve()
        {
            throw new NotImplementedException();
        }
        public Osoba PretragaKorisnickoImeLozinka(string korisnickoIme, string lozinka)
        {
            try
            {
                return context.Osoba.SingleOrDefault(o => o.UserName == korisnickoIme && o.PasswordHash == lozinka);
            }
            catch { throw new Exception(); }
        }
    }
}
