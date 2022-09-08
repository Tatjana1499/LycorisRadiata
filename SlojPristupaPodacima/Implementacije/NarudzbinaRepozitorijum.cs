using Domen;
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

        public void Dodaj(Narudzbina entitet)
        {
            context.Narudzbina.Add(entitet);
            //context.Narudzbina.
        }

        public List<Narudzbina> Pretraga(Expression<Func<Narudzbina, bool>> uslov)
        {
            throw new NotImplementedException();
        }

        public List<Narudzbina> VratiSve()
        {
            throw new NotImplementedException();
        }
    }
}
