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
          //  var tr = context.Database.BeginTransaction();

        }

        public List<CvetniAranzman> Pretraga(Expression<Func<CvetniAranzman, bool>> uslov)
        {
            return context.CvetniAranzman.Include(c => c.Pakovanje).Include(c => c.Dekoracije).Where(uslov).ToList();
        }
        public List<CvetniAranzman> VratiSve()
        {
            return context.CvetniAranzman.ToList();
        }
        public CvetniAranzman PretragaId(int id)
        {
            return context.CvetniAranzman.Include(c => c.Pakovanje).Include(c => c.Dekoracije).Single(c => c.ProizvodId == id);
        }
    }
}
