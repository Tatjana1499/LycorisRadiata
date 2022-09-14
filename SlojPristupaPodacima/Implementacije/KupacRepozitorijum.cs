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
            try
            {
                context.Update(entitet);
            }
            catch { throw new Exception(); }
        }

        public void Brisi(Kupac entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Kupac entitet)
        {
            try
            {
                context.Kupac.Add(entitet);
            }
            catch { throw new Exception(); }
        }

        public List<Kupac> Pretraga(Expression<Func<Kupac, bool>> uslov)
        {
            try
            {
                return context.Kupac.Where(uslov).ToList();
            }
            catch {  throw new Exception(); }
        }

        public List<Kupac> VratiSve()
        {
            throw new NotImplementedException();
        }

        public Kupac PretragaKorisnickoImeLozinka(string korisnickoIme, string lozinka)
        {
            try
            {
                return context.Kupac.SingleOrDefault(k => k.UserName == korisnickoIme && k.PasswordHash == lozinka);
            }
            catch { throw new Exception(); }
        }
        public Kupac PretragaId(int id)
        {
            try
            {
                return context.Kupac.Single(k => k.Id == id);
            }
            catch { throw new Exception(); }
        }
    }
}
