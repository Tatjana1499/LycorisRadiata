using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class PakovanjeRepozitorijum : IPakovanjeRepozitorijum
    {
        private readonly CvecaraContext context;

        public PakovanjeRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Pakovanje entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(Pakovanje entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Pakovanje entitet)
        {
            context.Add(entitet);
        }

        public List<Pakovanje> Pretraga(Expression<Func<Pakovanje, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<Pakovanje> VratiSve()
        {
            try
            {
                return context.Pakovanje.ToList();

            }
            catch
            {
                throw new Exception();
            }
        }
        public Pakovanje PretragaId(int id)
        {
            try
            {
                return context.Pakovanje.Single(p => p.PakovanjeId == id);
            }
            catch { throw new Exception(); }
        }
    }
}
