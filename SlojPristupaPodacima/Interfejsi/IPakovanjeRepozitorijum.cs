using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface IPakovanjeRepozitorijum : IRepozitorijum<Pakovanje>
    {
        public Pakovanje PretragaId(int id);
    }
}
