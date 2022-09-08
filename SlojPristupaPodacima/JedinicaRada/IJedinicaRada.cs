using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima.JedinicaRada
{
    public interface IJedinicaRada
    {
        public ICvetniAranzmanRepozitorijum CvetniAranzmanRepozitorijum { get; set; }
        public IKupacRepozitorijum KupacRepozitorijum { get; set; }
        public IPakovanjeRepozitorijum PakovanjeRepozitorijum { get; set; }
        public ICvetRepozitorijum CvetRepozitorijum { get; set; }
        public IProdajnoMestoRepozitorijum ProdajnoMestoRepozitorijum { get; set; }
        public IDekoracijaRepozitorijum DekoracijaRepozitorijum { get; set; }
        public IProizvodRepozitorijum ProizvodRepozitorijum { get; set; }
        public INarudzbinaRepozitorijum NarudzbinaRepozitorijum { get; set; }
        public void Sacuvaj();
    }
}
