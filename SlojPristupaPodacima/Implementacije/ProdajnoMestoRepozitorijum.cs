using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class ProdajnoMestoRepozitorijum : IProdajnoMestoRepozitorijum
    {
        private readonly CvecaraContext context;

        public ProdajnoMestoRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(ProdajnoMesto entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(ProdajnoMesto entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(ProdajnoMesto entitet)
        {
            throw new NotImplementedException();
        }

        public List<ProdajnoMesto> Pretraga(Expression<Func<ProdajnoMesto, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<ProdajnoMesto> VratiSve()
        {
            try
            {
                return context.ProdajnoMesto.ToList();
            }
            catch { throw new Exception(); }
        }
    }
}
