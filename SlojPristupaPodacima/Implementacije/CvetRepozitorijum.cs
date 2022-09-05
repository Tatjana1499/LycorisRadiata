using Domen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.Implementacije
{
    public class CvetRepozitorijum : ICvetRepozitorijum
    {
        private readonly CvecaraContext context;
        public CvetRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Cvet entitet)
        {
            context.Entry(entitet).State = EntityState.Modified;
        }

        public void Brisi(Cvet entitet)
        {
            context.Remove(entitet);
        }

        public void Dodaj(Cvet entitet)
        {
            context.Add(entitet);
        }

        public List<Cvet> Pretraga(Expression<Func<Cvet, bool>> uslov)
        {
            return context.Cvet.Where(uslov).ToList();
        }

        public List<Cvet> VratiSve()
        {
            return context.Cvet.ToList();
        }
        public Cvet PretragaId(int id)
        {
            return context.Cvet.Single(c => c.ProizvodId == id);
        }
    }
}
