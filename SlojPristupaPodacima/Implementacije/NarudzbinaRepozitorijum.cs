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
    class NarudzbinaRepozitorijum : INarudzbinaRepozitorijum
    {
        private readonly CvecaraContext context;

        public NarudzbinaRepozitorijum(CvecaraContext context)
        {
            this.context = context;
        }
        public void Azuriraj(Narudzbina entitet)
        {
            throw new NotImplementedException();
        }

        public void Brisi(Narudzbina entitet)
        {
            throw new NotImplementedException();
        }

        public void BrisiId(int id)
        {
            try
            {
                Narudzbina narudzbina = context.Narudzbina.Single(n => n.NarudzbinaId == id);
                context.Narudzbina.Remove(narudzbina);
            }
            catch
            {
                throw new Exception();
            }

        }

        public void Dodaj(Narudzbina entitet)
        {
            try 
            { 
                context.Narudzbina.Add(entitet);
            }
            catch
            {
                throw new Exception();
            }

}

        public List<Narudzbina> Pretraga(Expression<Func<Narudzbina, bool>> uslov)
        {
            try
            {
                return context.Narudzbina.Include(n => n.ProdajnoMesto).Where(uslov).ToList();
            }
            catch { throw new Exception(); }
        }

        public List<Narudzbina> VratiSve()
        {
            try
            {
                return context.Narudzbina.Include(n => n.Kupac).Include(n => n.ProdajnoMesto).ToList();
            }
            catch { throw new Exception(); }
        }
        public Narudzbina PretragaId(int id)
        {
            try
            {
                return context.Narudzbina.Include(n => n.Kupac).Single(c => c.NarudzbinaId == id);
            }
            catch { throw new Exception(); }
        }
        public List<Narudzbina> PretragaKupac(Expression<Func<Narudzbina, bool>> uslov)
        {
            try
            {
                return context.Narudzbina.Include(n => n.ProdajnoMesto).Include(n => n.Kupac).Where(uslov).ToList();
            }
            catch { throw new Exception(); }
        }
    }
}
