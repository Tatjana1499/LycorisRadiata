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
           
        }

        public void Brisi(Cvet entitet)
        {
            try
            {
                context.Remove(entitet);
            }
            catch { throw new Exception(); }
        }

        public void Dodaj(Cvet entitet)
        {
            try
            {
                context.Add(entitet);
            }
            catch { throw new Exception(); }
        }

        public List<Cvet> Pretraga(Expression<Func<Cvet, bool>> uslov)
        {
            try
            {
                return context.Cvet.Where(uslov).ToList();
            }
            catch { throw new Exception(); }
        }

        public List<Cvet> VratiSve()
        {
            try
            {
                return context.Cvet.ToList();
            }
            catch { throw new Exception(); }
        }
        public Cvet PretragaId(int id)
        {
            try
            {
                return context.Cvet.Single(c => c.ProizvodId == id);
            }
            catch { throw new Exception(); }
        }
    }
}
