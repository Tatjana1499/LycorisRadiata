using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Administrator : Osoba
    {
        public string SifraZaposlenog { get; set; }
        public DateTime DatumZaposlenja { get; set; }
    }
}
