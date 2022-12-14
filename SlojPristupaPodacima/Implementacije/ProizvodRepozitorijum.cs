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
    public class ProizvodRepozitorijum : IProizvodRepozitorijum
    {
        private readonly CvecaraContext context;
        public ProizvodRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Proizvod entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(Proizvod entitet)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(Proizvod entitet)
        {
            throw new NotImplementedException();
        }

        public List<Proizvod> Pretraga(Expression<Func<Proizvod, bool>> uslov)
        {
            throw new NotImplementedException();
        }
        public Proizvod PretragaId(int id)
        {
            try
            {
                return context.Proizvod.Single(p => p.ProizvodId == id);
            }
            catch { throw new Exception(); }
        }

        public List<Proizvod> VratiSve()
        {
            try
            {
                return context.Proizvod.ToList();
            }
            catch { throw new Exception(); }
        }
    }
}
