using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface INarudzbinaRepozitorijum : IRepozitorijum<Narudzbina>
    {
        public Narudzbina PretragaId(int id);
    }
}
