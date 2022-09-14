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
    public class DekoracijaRepozitorijum : IDekoracijaRepozitorijum
    {
        private readonly CvecaraContext context;

        public DekoracijaRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Dekoracija entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(Dekoracija entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Dekoracija entitet)
        {
            try
            {
                context.Dekoracija.Add(entitet);
            }
            catch { throw new Exception(); }
        }

        public List<Dekoracija> Pretraga(Expression<Func<Dekoracija, bool>> uslov)
        {
            try
            {
                return context.Dekoracija.Include(d => d.Cvet).Where(uslov).ToList();
            }
            catch { throw new Exception(); }
        }

        public List<Dekoracija> VratiSve()
        {
            throw new NotImplementedException();
        }
    }
}
