using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface INarudzbinaRepozitorijum : IRepozitorijum<Narudzbina>
    {
        public Narudzbina PretragaId(int id);
        public List<Narudzbina> PretragaKupac(Expression<Func<Narudzbina, bool>> uslov);
        public void BrisiId(int id);
    }
}
