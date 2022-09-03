using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class DekoracijaViewModel
    {
        public Cvet Cvet { get; set; }
        public int CvetProizvodId { get; set; }
        public int CvetniAranzmanProizvodId { get; set; }
        public int BrojCvetova { get; set; }
    }
}
