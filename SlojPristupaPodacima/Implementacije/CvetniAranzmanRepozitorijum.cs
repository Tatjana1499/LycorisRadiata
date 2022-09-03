using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class CvetniAranzmanRepozitorijum : ICvetniAranzmanRepozitorijum
    {
        private readonly CvecaraContext context;

        public CvetniAranzmanRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(CvetniAranzman entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(CvetniAranzman entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(CvetniAranzman entitet)
        {
            context.CvetniAranzman.Add(entitet);
        }

        public List<CvetniAranzman> Pretraga(Expression<Func<CvetniAranzman, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<CvetniAranzman> VratiSve()
        {
            throw new NotImplementedException();
        }
    }
}
