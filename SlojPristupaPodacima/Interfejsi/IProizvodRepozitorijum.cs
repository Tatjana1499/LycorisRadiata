﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface IProizvodRepozitorijum : IRepozitorijum<Proizvod>
    {
        public Proizvod PretragaId(int id);
    }
}
