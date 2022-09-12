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
            Narudzbina narudzbina = context.Narudzbina.Single(n => n.NarudzbinaId == id);
            context.Narudzbina.Remove(narudzbina);
        }

        public void Dodaj(Narudzbina entitet)
        {
            context.Narudzbina.Add(entitet);
        }

        public List<Narudzbina> Pretraga(Expression<Func<Narudzbina, bool>> uslov)
        {
            return context.Narudzbina.Include(n => n.ProdajnoMesto).Where(uslov).ToList();
        }

        public List<Narudzbina> VratiSve()
        {
            return context.Narudzbina.Include(n => n.Kupac).Include(n => n.ProdajnoMesto).ToList();
        }
        public Narudzbina PretragaId(int id)
        {
            return context.Narudzbina.Include(n => n.Kupac).Single(c => c.NarudzbinaId == id);
        }
        public List<Narudzbina> PretragaKupac(Expression<Func<Narudzbina, bool>> uslov)
        {
            return context.Narudzbina.Include(n => n.ProdajnoMesto).Include(n => n.Kupac).Where(uslov).ToList();
        }
    }
}
