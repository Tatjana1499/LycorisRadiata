using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class KupacRepozitorijum : IKupacRepozitorijum
    {
        private readonly CvecaraContext context;

        public KupacRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Kupac entitet)
        {
            context.Update(entitet);
        }

        public void Brisi(Kupac entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Kupac entitet)
        {
            context.Kupac.Add(entitet);
        }

        public List<Kupac> Pretraga(Expression<Func<Kupac, bool>> uslov)
        {
            return context.Kupac.Where(uslov).ToList();
        }

        public List<Kupac> VratiSve()
        {
            throw new NotImplementedException();
        }

        public Kupac PretragaKorisnickoImeLozinka(string korisnickoIme, string lozinka)
        {
            return context.Kupac.SingleOrDefault(k => k.UserName == korisnickoIme && k.PasswordHash == lozinka);
        }
        public Kupac PretragaId(int id)
        {
            return context.Kupac.Single(k => k.Id == id);
        }
    }
}
