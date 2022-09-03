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
            throw new NotImplementedException();
        }

        public List<Pakovanje> Pretraga(Expression<Func<Pakovanje, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<Pakovanje> VratiSve()
        {
            return context.Pakovanje.ToList();
        }
    }
}
