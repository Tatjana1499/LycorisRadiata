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
            try
            {
                context.CvetniAranzman.Add(entitet);
            }
            catch
            {
                throw new Exception();
            }
        }

        public List<CvetniAranzman> Pretraga(Expression<Func<CvetniAranzman, bool>> uslov)
        {
            try
            {
                return context.CvetniAranzman.Include(c => c.Pakovanje).Include(c => c.Dekoracije).Where(uslov).ToList();
            }
            catch
            {
                throw new Exception();
            }
        }
        public List<CvetniAranzman> VratiSve()
        {
            try
            {
                return context.CvetniAranzman.ToList();
            }
            catch
            {
                throw new Exception();
            }
        }
        public CvetniAranzman PretragaId(int id)
        {
            try
            {
                return context.CvetniAranzman.Include(c => c.Pakovanje).Include(c => c.Dekoracije).Single(c => c.ProizvodId == id);
            }
            catch 
            {
                throw new Exception();
            }
        }
    }
}
