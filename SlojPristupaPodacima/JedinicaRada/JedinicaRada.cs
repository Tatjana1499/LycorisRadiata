﻿using Domen;
using SlojPristupaPodacima.Implementacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.JedinicaRada
{
    public class JedinicaRada : IJedinicaRada
    {
        private readonly CvecaraContext context;

        public JedinicaRada(CvecaraContext context)
        {
            this.context = context;
            //CvetniAranzmanRepozitorijum = new CvetniAranzmanRepozitorijum(context);
            CvetRepozitorijum = new CvetRepozitorijum(context);
        }
        public ICvetniAranzmanRepozitorijum CvetniAranzmanRepozitorijum { get; set; }
        public IKupacRepozitorijum KupacRepozitorijum { get; set; }
        public IPakovanjeRepozitorijum PakovanjeRepozitorijum { get; set; }
        public ICvetRepozitorijum CvetRepozitorijum { get; set; }

        public void Sacuvaj()
        {
            context.SaveChanges();
        }
    }
}